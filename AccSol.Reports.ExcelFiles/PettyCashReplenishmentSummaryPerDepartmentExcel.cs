using AccSol.ViewModels;
using AccSol.Excel;
using NPOI.SS.UserModel;
using AccSol.Common.Extensions;
using NPOI.XSSF.UserModel;
using AccSol.Common.Reports;
using ICell = NPOI.SS.UserModel.ICell;
using static NPOI.HSSF.Util.HSSFColor;
using NPOI.OpenXmlFormats.Dml;

namespace AccSol.Reports.ExcelFiles
{
    public class PettyCashReplenishmentSummaryPerDepartmentExcel :AccSolWorkBook
    {
        private DateTime _fromDate;
        private DateTime _toDate;
        private string _fromPCFNo;
        private string _toPCFNo;
        private ICellStyle _headerCellStyle;
        private ICellStyle _journalCellStyle;
        private ICellStyle _detailCellStyle;
        private ICellStyle _detailAltCellStyle;
        private ICellStyle _detailNumericCellStyle;
        private ICellStyle _detailAltNumericCellStyle;
        private ICellStyle _totalsCellStyle;
        private byte[] _white;
        private byte[] _black;
        private byte[] _darkGrey;
        private IFont _titleFontNormal;
        private IFont _titleFontBold;
        private IFont _headerFont;
        private IFont _detailFont;
        private IFont _totalsFont;
        private ICellStyle _titleCellStyleNormal;
        private ICellStyle _titleCellStyleBold;
        private byte[] _bluishGrey;

        public PettyCashReplenishmentSummaryPerDepartmentExcel(string sheetName) : base(sheetName)
        {
            Console.WriteLine("Sheet Name: {0}", sheetName);
        }

        public PettyCashReplenishmentSummaryPerDepartmentExcel(string excelFilePath, string sheetName): base(excelFilePath, sheetName)
        {
            Console.WriteLine("Excel File: {0}", excelFilePath);
            Console.WriteLine("Sheet Name: {0}", sheetName);
        }
        public async Task CreateSampleExcelFile()
        {
            XSSFWorkbook workbook = new XSSFWorkbook();
            ISheet sheet1 = workbook.CreateSheet("Sheet1");

            // Create a header row
            IRow row1 = sheet1.CreateRow(0);
            ICell cellA1 = row1.CreateCell(0);
            cellA1.SetCellValue("Hello, world!");

            // Create a style for the header
            XSSFCellStyle style1 = (XSSFCellStyle)workbook.CreateCellStyle();
            style1.SetFillForegroundColor(new XSSFColor(new byte[] { 173, 216, 230 })); // Light Blue color
            style1.FillPattern = FillPattern.SolidForeground;

            // Apply the style to the cell
            cellA1.CellStyle = style1;

            // Save the file
            using (FileStream file = new FileStream("test.xlsx", FileMode.Create))
            {
                workbook.Write(file);
                file.Close();
            }

            await Task.CompletedTask;
        }

        public async Task CreateExcelFromGroupReportsAsync(List<GroupedReportData<PettyCashSummaryReportVM>> groupedReports)
        {
            try 
            {
                await CreateHeaderRowAsync();
                await InitializePropertiesAsync(groupedReports);
                await SetCellValueAsync(rowIndex: 0, colIndex: 0, cellValue: "Petty Cash Replenishment Summary Report", _titleCellStyleBold, formula: "");

                await SetForThePeriodAsync();

                await SetPettyCashNumberAsync();

                //table headers
                await SetHeaderCellAsync(startRowIndex: 3, endRowIndex: 4, startColIndex: 0, endColIndex: 0, cellValue: "PCF#", colWidth: 10 * 256);
                await SetHeaderCellAsync(startRowIndex: 3, endRowIndex: 4, startColIndex: 1, endColIndex: 1, cellValue: "DATE", colWidth: 15 * 256);
                await SetHeaderCellAsync(startRowIndex: 3, endRowIndex: 4, startColIndex: 2, endColIndex: 2, cellValue: "PAYEE", colWidth: 30 * 256);
                await SetHeaderCellAsync(startRowIndex: 3, endRowIndex: 4, startColIndex: 3, endColIndex: 3, cellValue: "DEPARTMENT", colWidth: 30 * 256);
                await SetHeaderCellAsync(startRowIndex: 3, endRowIndex: 4, startColIndex: 4, endColIndex: 4, cellValue: "PARTICULARS", colWidth: 50 * 256);
                await SetHeaderCellAsync(startRowIndex: 3, endRowIndex: 4, startColIndex: 5, endColIndex: 5, cellValue: "CLIENT", colWidth: 40 * 256);
                await SetHeaderCellAsync(startRowIndex: 3, endRowIndex: 4, startColIndex: 6, endColIndex: 6, cellValue: "PROJECT CODE", colWidth: 20 * 256);
                await SetHeaderCellAsync(startRowIndex: 3, endRowIndex: 4, startColIndex: 7, endColIndex: 7, cellValue: "AMOUNT", colWidth: 15 * 256);
                await SetJournalEntryHeaderCellAsync();
                await SetJournalEntryHeaderCellAsync(rowIndex: 4, colIndex: 8, cellValue: "ACCT NAME", colWidth: 30 * 256);
                await SetJournalEntryHeaderCellAsync(rowIndex: 4, colIndex: 9, cellValue: "DEBIT", colWidth: 20 * 256);
                await SetJournalEntryHeaderCellAsync(rowIndex: 4, colIndex: 10, cellValue: "CREDIT", colWidth: 20 * 256);

                await SetDetailRowsAsync(groupedReports);
            }
            catch (Exception ex)
            {
                Console.WriteLine("CreateHeaderRowFromList(List<PettyCashSummaryReportVM> list): {0}\r\n{1}", ex.Message, ex.StackTrace);
            }
        }

        private async Task InitializePropertiesAsync(List<GroupedReportData<PettyCashSummaryReportVM>> groupedReports)
        {
            var allItems = groupedReports.SelectMany(gr => gr.Items).ToList();

            if (allItems.Any())
            {
                _fromDate = allItems.Min(l => l.Date) ?? DateTime.MinValue;
                _toDate = allItems.Max(l => l.Date) ?? DateTime.MinValue;
                _fromPCFNo = allItems.Min(l => l.PCFNo) ?? string.Empty;
                _toPCFNo = allItems.Max(l => l.PCFNo) ?? string.Empty;
            }

            _white = new byte[] { 255, 255, 255 };
            _black = new byte[] { 0, 0, 0 };
            _darkGrey = new byte[] { 108, 117, 125};
            _bluishGrey = new byte[] { 242, 242, 242 };

            // Create new fonts
            _titleFontNormal = await CreateFont(fontName: "Helvetica Neue", fontHeightInPoints: 12, isBold: false, fontColor: _black);
            _titleFontBold = await CreateFont(fontName: "Helvetica Neue", fontHeightInPoints: 12, isBold: true, fontColor: _black);
            _headerFont = await CreateFont(fontName: "Helvetica Neue", fontHeightInPoints: 12, isBold: true, fontColor: _white);
            _detailFont = await CreateFont(fontName: "Helvetica Neue", fontHeightInPoints: 10, isBold: false, fontColor: _black);
            _totalsFont = await CreateFont(fontName: "Helvetica Neue", fontHeightInPoints: 12, isBold: true, fontColor: _black);

            // Create a new style for titles
            _titleCellStyleNormal = await CreateStyle(_titleFontNormal, HorizontalAlignment.Left, VerticalAlignment.Center, bgColor: _white);
            _titleCellStyleBold = await CreateStyle(_titleFontBold, HorizontalAlignment.Left, VerticalAlignment.Center, bgColor: _white);
            
            // Create a new style for header
            _headerCellStyle = await CreateStyle(_headerFont, HorizontalAlignment.Left, VerticalAlignment.Center, bgColor: _darkGrey);
            
            // Create a new style for journal
            _journalCellStyle = await CreateStyle(_headerFont, HorizontalAlignment.Center, VerticalAlignment.Center, bgColor: _darkGrey);

            // Create a new style for detail rows
            _detailCellStyle = await CreateStyle(_detailFont, HorizontalAlignment.Left, VerticalAlignment.Center, bgColor: _white);
            _detailAltCellStyle = await CreateStyle(_detailFont, HorizontalAlignment.Left, VerticalAlignment.Center, bgColor: _bluishGrey);

            // Create a new style for detail columns that are numeric types
            _detailNumericCellStyle = await CreateStyle(_detailFont, HorizontalAlignment.Right, VerticalAlignment.Center, bgColor: _white);
            _detailAltNumericCellStyle = await CreateStyle(_detailFont, HorizontalAlignment.Right, VerticalAlignment.Center, bgColor: _bluishGrey);
            
            // Create a new style for totals row
            _totalsCellStyle = await CreateStyle(_totalsFont, HorizontalAlignment.Right, VerticalAlignment.Center, bgColor: _white);

            // how to get the font:
            //IFont _headerFont = AccSolBook.GetFontAt(_journalCellStyle.FontIndex);

        }
        
        private async Task SetForThePeriodAsync()
        {
            var cell = await SetCellValueAsync(rowIndex: 1, colIndex: 0, cellValue: "For the period: ", _titleCellStyleNormal, formula: "", isRichText: true);

            string fromDateString = _fromDate.To_MMM_dd_yyyy() ?? string.Empty;
            string toDateString = _toDate.To_MMM_dd_yyyy() ?? string.Empty;
            var period = $"{fromDateString} to {toDateString}";
            await AddTextToRichTextCell(cell, period, _titleFontBold);
        }

        private async Task SetPettyCashNumberAsync()
        {
            var cell = await SetCellValueAsync(rowIndex: 2, colIndex: 0, cellValue: "Petty Cash Number: ", _titleCellStyleNormal, formula: "", isRichText: true);

            var pettyCashText = $"{_fromPCFNo} to {_toPCFNo}";
            await AddTextToRichTextCell(cell, pettyCashText, _titleFontBold);
 
        }
        
        private async Task SetHeaderCellAsync(int startRowIndex, int endRowIndex, int startColIndex, int endColIndex, string cellValue, int colWidth)
        {
            await CreateMergedRichTextCell(startRowIndex, endRowIndex, startColIndex, endColIndex, value: cellValue, _headerFont, formula:"", _headerCellStyle);
            await SetColumnWidth(col: startColIndex, colWidth);
        }

        private async Task SetJournalEntryHeaderCellAsync()
        {
            await CreateMergedRichTextCell(startRowIndex: 3, endRowIndex: 3, startColIndex: 8, endColIndex: 10, value: "JOURNAL ENTRIES", _headerFont, formula: "", _journalCellStyle);
        }

        private async Task SetJournalEntryHeaderCellAsync(int rowIndex, int colIndex, string cellValue, int colWidth)
        {
            await SetCellValueAsync(rowIndex, colIndex, cellValue, _headerCellStyle, formula: "", isRichText: true);
            await SetColumnWidth(colIndex, colWidth);
        }

        private async Task SetDetailRowsAsync(List<GroupedReportData<PettyCashSummaryReportVM>> groupedReports)
        {
            string totalAmount = string.Empty;
            string totalDebit = string.Empty;
            string totalCredit = string.Empty;
            int rowIndex = 5;
            int colIndex = 0;
            //table details
            bool isAlt = false;
            if (groupedReports != null)
            {
                foreach (var group in groupedReports)
                {
                    if (group.Items != null)
                    {
                        var pcfNo = string.Empty;
                        string cellValue = string.Empty;
                        foreach (var pettyCashVM in group.Items)
                        {
                            colIndex = 0;
                            bool suppress = pettyCashVM.PCFNo == pcfNo;
                            pcfNo = pettyCashVM.PCFNo;

                            await SetDetailCellValueAsync(suppress, rowIndex, colIndex++, cellValue: pettyCashVM.PCFNo, isAlt? _detailAltCellStyle: _detailCellStyle, formula:"");
                            await SetDetailCellValueAsync(suppress, rowIndex, colIndex++, cellValue: pettyCashVM.Date, isAlt ? _detailAltCellStyle : _detailCellStyle, formula: "");
                            await SetDetailCellValueAsync(suppress, rowIndex, colIndex++, cellValue: pettyCashVM.Payee, isAlt ? _detailAltCellStyle : _detailCellStyle, formula: "");
                            await SetDetailCellValueAsync(suppress, rowIndex, colIndex++, cellValue: pettyCashVM.DepartmentName, isAlt ? _detailAltCellStyle : _detailCellStyle, formula: "");
                            await SetDetailCellValueAsync(suppress, rowIndex, colIndex++, cellValue: pettyCashVM.Particulars, isAlt ? _detailAltCellStyle : _detailCellStyle, formula: "");
                            await SetDetailCellValueAsync(suppress, rowIndex, colIndex++, cellValue: pettyCashVM.ClientName, isAlt ? _detailAltCellStyle : _detailCellStyle, formula: "");
                            await SetDetailCellValueAsync(suppress, rowIndex, colIndex++, cellValue: pettyCashVM.ProjectCode, isAlt ? _detailAltCellStyle : _detailCellStyle, formula: "");
                            await SetDetailCellValueAsync(suppress, rowIndex, colIndex++, cellValue: pettyCashVM.Amount, isAlt ? _detailAltNumericCellStyle : _detailNumericCellStyle, formula: $"TEXT({pettyCashVM.Amount}, \"#,##0.00\")");
                            await SetDetailCellValueAsync(suppress: false, rowIndex, colIndex++, cellValue: pettyCashVM.AccountName, isAlt ? _detailAltCellStyle : _detailCellStyle, formula: "");
                            await SetDetailCellValueAsync(suppress: false, rowIndex, colIndex++, cellValue: pettyCashVM.Debit, isAlt ? _detailAltNumericCellStyle : _detailNumericCellStyle, formula: $"TEXT({pettyCashVM.Debit}, \"#,##0.00\")");
                            await SetDetailCellValueAsync(suppress: false, rowIndex, colIndex++, cellValue: pettyCashVM.Credit, isAlt ? _detailAltNumericCellStyle : _detailNumericCellStyle, formula: $"TEXT({pettyCashVM.Credit}, \"#,##0.00\")");

                            rowIndex++;
                            isAlt = !isAlt;
                        }
                    }
                    //group totals
                }

                //grand totals
                colIndex = 0;

                await SetTotalsRowCellAsync(rowIndex, colIndex, cellValue: "Totals", _totalsCellStyle, formula: "");

                totalAmount = groupedReports.Sum(g => Convert.ToDecimal(g.Totals["Amount"].ToString())).ToString() ?? string.Empty;
                totalDebit = groupedReports.Sum(g => Convert.ToDecimal(g.Totals["Debit"].ToString())).ToString() ?? string.Empty;
                totalCredit = groupedReports.Sum(g => Convert.ToDecimal(g.Totals["Credit"].ToString())).ToString() ?? string.Empty;

                await SetTotalsRowCellAsync(rowIndex, colIndex:7, cellValue: totalAmount, _totalsCellStyle, formula: $"TEXT({totalAmount}, \"#,##0.00\")");
                await SetTotalsRowCellAsync(rowIndex, colIndex:9, cellValue: totalDebit, _totalsCellStyle, formula: $"TEXT({totalDebit}, \"#,##0.00\")");
                await SetTotalsRowCellAsync(rowIndex, colIndex:10, cellValue: totalCredit, _totalsCellStyle, formula: $"TEXT({totalCredit}, \"#,##0.00\")");
                 
            }

        }

        private async Task SetTotalsRowCellAsync(int rowIndex, int colIndex, string cellValue, ICellStyle cellStyle, string formula)
        {
            //Console.WriteLine("Font Color: {0}", cellStyle.GetFont(AccSolBook).Color);
            var cell = await SetCellValueAsync(rowIndex, colIndex, cellValue, cellStyle, formula, isRichText: true);
        }

        private async Task SetDetailCellValueAsync(bool suppress, int rowIndex, int colIndex, object? cellValue, ICellStyle cellStyle, string formula)
        {
            //string cellValueString = suppress ? string.Empty : cellValue switch
            //{
            //    DateTime date => date.To_MM_dd_yyyy(),
            //    decimal dec => dec.ToString(),
            //    _ => cellValue?.ToString() ?? string.Empty
            //};

            cellValue = suppress ? null : cellValue;
            var cell = await SetCellValueAsync(rowIndex, colIndex, cellValue, cellStyle, formula, isRichText: true);

            cellStyle.BorderTop = BorderStyle.Thin;
            cellStyle.BorderBottom = BorderStyle.Thin;
            cellStyle.BorderLeft = BorderStyle.Thin;
            cellStyle.BorderRight = BorderStyle.Thin;
            //await CreateRichTextCell(rowIndex, colIndex, cellValueString, _detailFont, cellStyle );

            //await SetColumnWidth(colIndex, colWidth);


        }
    }
}
