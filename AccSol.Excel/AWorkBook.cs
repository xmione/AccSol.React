using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using ICell = NPOI.SS.UserModel.ICell;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.SS.Util;
using NPOI.OOXML.XSSF.UserModel;

namespace AccSol.Excel
{
    public abstract class AWorkBook
    {
        private IWorkbook _workBook = default!;
        private ISheet _currentSheet = default!;
        private IRow _currentRow = default!;
        private ICell _currentCell = default!;
        private Dictionary<string, ISheet> _workSheets = default!;
        private string _excelFilePath = default!; 
        private string _sheetName = default!; 

        public IWorkbook AccSolBook 
        {
            get { return _workBook; }
        }
        public async Task CreateExcelFile(string sheetName)
        {
            _sheetName = sheetName;
            _workSheets = new Dictionary<string, ISheet>();

            await CreateWorkBook();
            await CreateWorkSheet();
            await Task.CompletedTask;
        }
        public async Task CreateExcelFile(string excelFilePath, string sheetName)
        {
            _excelFilePath = excelFilePath;
            _sheetName = sheetName;
            _workSheets = new Dictionary<string, ISheet>();

            await CreateWorkBook();
            await CreateWorkSheet();
            await Task.CompletedTask;
        }
        private async Task CreateWorkBook()
        {
            _workBook = new XSSFWorkbook();

            await Task.CompletedTask;
        }
        private async Task CreateWorkSheet()
        {
            try 
            {
                _currentSheet = _workBook.CreateSheet(_sheetName);
                _workSheets.Add(_sheetName, _currentSheet);

                await Task.CompletedTask;
            }
            catch (Exception ex)
            {
                Console.WriteLine("CreateWorkSheet(): {0}\r\n{1}", ex.Message, ex.StackTrace);
            }
        }
        /// <summary>
        /// Creates a worksheet header row. This is optional.
        /// </summary>
        /// <returns></returns>
        public virtual async Task CreateHeaderRowAsync()
        {
            // Create a header row
            _currentRow = _currentSheet.CreateRow(0);
            _currentCell = _currentRow.CreateCell(0);

            await Task.CompletedTask;
        }

        public virtual async Task<IFont> CreateFont(string fontName, int fontHeightInPoints, bool isBold, byte[] fontColor)
        { 
            IFont font;
            // Create a new font
            font = _workBook.CreateFont();
            font.FontName = fontName;
            font.FontHeightInPoints = (short)fontHeightInPoints;
            font.IsBold = isBold;

            // Set the color if the workbook is an XSSFWorkbook
            if (_workBook is XSSFWorkbook xssfWorkbook)
            {
                XSSFColor color = new XSSFColor(fontColor);
                ((XSSFFont)font).SetColor(color);
            }

            await Task.CompletedTask;

            return font;
        }

        public virtual async Task<ICellStyle> CreateStyle(IFont font, HorizontalAlignment hAlignment, VerticalAlignment vAlignment, byte[] bgColor)
        {
            ICellStyle cellStyle = _workBook.CreateCellStyle();
            cellStyle.SetFont(font);
            cellStyle.Alignment = hAlignment;
            cellStyle.VerticalAlignment = vAlignment;

            // Set the fill foreground color if the workbook is an XSSFWorkbook
            if (_workBook is XSSFWorkbook xssfWorkbook)
            {
                XSSFColor color = new XSSFColor(bgColor);
                ((XSSFCellStyle)cellStyle).SetFillForegroundColor(color);
                cellStyle.FillPattern = FillPattern.SolidForeground;
            }

            await Task.CompletedTask;

            return cellStyle;
        }

        public virtual async Task FormatCurrentCell(ICellStyle style)
        {
            _currentCell.CellStyle = style;
            await Task.CompletedTask;
        }
        public virtual async Task<ICellStyle> FormatCurrentCellAsync(string fontName = "Calibri", int fontSize = 12, bool isBold = false, byte[]? fillForeGroundColor = null!)
        {
            ICellStyle style = default!;

            try
            {
                IFont font = _workBook.CreateFont();
                font.FontName = fontName; // Set the font
                font.FontHeightInPoints = (short)fontSize; // Set the size
                font.IsBold = isBold; // Set bold

                style = _workBook.CreateCellStyle();
                style.SetFont(font); // Apply the font to the style

                // Set the fill foreground color if it's provided
                if (fillForeGroundColor != null)
                {
                    if (_workBook is XSSFWorkbook xssfWorkbook)
                    {
                        XSSFCellStyle xssfStyle = (XSSFCellStyle)style;
                        xssfStyle.SetFillForegroundColor(new XSSFColor(fillForeGroundColor));
                        xssfStyle.FillPattern = FillPattern.SolidForeground;
                    }
                    else if (_workBook is HSSFWorkbook hssfWorkbook)
                    {
                        // For HSSF, you need to create a custom palette color
                        HSSFPalette palette = hssfWorkbook.GetCustomPalette();
                        HSSFColor hssfColor = palette.FindSimilarColor(fillForeGroundColor[0], fillForeGroundColor[1], fillForeGroundColor[2]);
                        style.FillForegroundColor = hssfColor.Indexed;
                        style.FillPattern = FillPattern.SolidForeground;
                    }
                }

                _currentCell.CellStyle = style; // Apply the style to the cell

                await Task.CompletedTask;
            }
            catch (Exception ex)
            {
                Console.WriteLine("FormatCurrentCellAsync(string fontName = \"Calibri\", int fontSize = 12, bool isBold = false, byte[] fillForeGroundColor = null): {0}\r\n{1}", ex.Message, ex.StackTrace);
            }

            return style;
        }

        public virtual async Task CurrentCellFormula(string formula)
        {
            _currentCell.SetCellFormula(formula);
            await Task.CompletedTask;
        }

        public async Task<ICell> WriteToCell(int rowIndex, int colIndex, object cellValue, string formula, ICellStyle style)
        {
            // Get the row
            IRow row = _currentSheet.GetRow(rowIndex) ?? _currentSheet.CreateRow(rowIndex);

            // Create the cell
            _currentCell = row.CreateCell(colIndex);

            // Check the type of cellValue and set the cell value accordingly
            switch (cellValue)
            {
                case double numericValue:
                    _currentCell.SetCellValue(numericValue);
                    break;
                case DateTime dateValue:
                    _currentCell.SetCellValue(dateValue);
                    break;
                case string stringValue:
                    _currentCell.SetCellValue(stringValue);
                    break;
                default:
                    _currentCell.SetCellValue(cellValue.ToString());
                    break;
            }

            // Apply formatting
            _currentCell.CellStyle = style;

            if (!string.IsNullOrEmpty(formula))
            {
                // Set the formula
                _currentCell.SetCellFormula(formula);
            }

            await Task.CompletedTask;

            return _currentCell;
        }

        public async Task<ICell> CreateRichTextCell(int rowIndex, int colIndex, string value, IFont font, ICellStyle style, string formula = "")
        {
            // Get the row
            IRow row = _currentSheet.GetRow(rowIndex) ?? _currentSheet.CreateRow(rowIndex);

            // Create the cell
            _currentCell = row.CreateCell(colIndex);

            // Check if a formula is provided
            if (!string.IsNullOrEmpty(formula))
            {
                // Set the cell's formula
                _currentCell.SetCellFormula(formula);
            }
            else
            {
                // Create the rich text string
                XSSFRichTextString richString = new XSSFRichTextString(value);

                // Apply the font to the rich text string
                richString.ApplyFont(0, value.Length, font);

                // Set the rich text string as the cell value
                _currentCell.SetCellValue(richString);
            }

            // Apply the cell style
            _currentCell.CellStyle = style;

            await Task.CompletedTask;

            return _currentCell;
        }

        public async Task<ICell> SetCellValueAsync(int rowIndex, int colIndex, object cellValue, ICellStyle cellStyle, string formula, bool isRichText = false)
        {
            ICell cell;
            
            if (isRichText)
            {
                IFont cellFont = cellStyle.GetFont(AccSolBook);
                string cellValueString = cellValue?.ToString() ?? string.Empty;
                cell = await CreateRichTextCell(rowIndex, colIndex, cellValueString, cellFont, cellStyle, formula);
            }
            else
            {
                cell = await WriteToCell(rowIndex, colIndex, cellValue, formula, cellStyle);
            }

            return cell;
        }


        public async Task AddTextToRichTextCell(ICell cell, string value, IFont font)
        {
            // Get the current rich text string
            XSSFRichTextString richString = (XSSFRichTextString)cell.RichStringCellValue;

            // Create a new rich text string with the combined text
            XSSFRichTextString newRichString = new XSSFRichTextString(richString + value);

            // Apply the font to the part of the string that should be bold
            newRichString.ApplyFont(richString.Length, richString.Length + value.Length, font);

            // Set the new rich text string as the cell value
            cell.SetCellValue(newRichString);

            await Task.CompletedTask;
        }

        public async Task<ICell> CreateMergedRichTextCell(int startRowIndex, int endRowIndex, int startColIndex, int endColIndex, string value, IFont font, string formula, ICellStyle style)
        {
            // Merge the cells
            _currentSheet.AddMergedRegion(new CellRangeAddress(startRowIndex, endRowIndex, startColIndex, endColIndex));

            // Get the first row
            IRow row = _currentSheet.GetRow(startRowIndex);
            if (row == null)
            {
                row = _currentSheet.CreateRow(startRowIndex);
            }

            // Create the cell
            _currentCell = row.CreateCell(startColIndex);

            // Create the rich text string
            XSSFRichTextString richString = new XSSFRichTextString(value);

            // Apply the font to the rich text string
            richString.ApplyFont(0, value.Length, font);

            // Set the rich text string as the cell value
            _currentCell.SetCellValue(richString);

            // Apply formatting
            _currentCell.CellStyle = style;

            if (!string.IsNullOrEmpty(formula))
            {
                // Set the formula
                _currentCell.SetCellFormula(formula);
            }
             
            await Task.CompletedTask;

            return _currentCell;
        }

        public async Task<XSSFCellStyle> SetCellForegroundFill(ICellStyle cellStyle, byte[] rgbColors)
        {
            // Create a new XSSFCellStyle
            XSSFCellStyle xssfCellStyle = (XSSFCellStyle)cellStyle;

            // Create a new XSSFColor
            XSSFColor newColor = new XSSFColor(rgbColors);

            // Set the fill foreground color
            xssfCellStyle.SetFillForegroundColor(newColor);
            xssfCellStyle.FillPattern = FillPattern.SolidForeground;

            await Task.CompletedTask;
            return xssfCellStyle;
        }
        public async Task SetColumnWidth(int col, int width)
        {
            _currentSheet.SetColumnWidth(col, width);
            await Task.CompletedTask;
        }

        public async Task ApplyAlternatingRowColorsAsync(int startRowIndex, int endRowIndex, byte[] rgbColor1, byte[] rgbColor2)
        {
            for (int i = startRowIndex; i <= endRowIndex; i++)
            {
                IRow row = _currentSheet.GetRow(i);

                // Create a new XSSFColor with the appropriate RGB value
                XSSFColor color = new XSSFColor(i % 2 == 0 ? rgbColor1 : rgbColor2);

                // Apply the style to each cell in the row
                foreach (ICell cell in row)
                {
                    // Get the existing style of the cell
                    XSSFCellStyle cellStyle = (XSSFCellStyle)cell.CellStyle;

                    // Modify the fill foreground color and fill pattern of the existing style
                    cellStyle.SetFillForegroundColor(color);
                    cellStyle.FillPattern = FillPattern.SolidForeground;

                    // Apply the modified style back to the cell
                    cell.CellStyle = cellStyle;
                }
            }

            await Task.CompletedTask;
        }


        public enum BorderStyles
        {
            NoBorder,
            Thin,
            Medium,
            Thick,
            Dotted,
            Dashed,
            Double
        }

        public void SetBorder(int startRowIndex, int endRowIndex, int startColIndex, int endColIndex, BorderStyles borderStyle)
        {
            BorderStyle style;
            switch (borderStyle)
            {
                case BorderStyles.NoBorder:
                    style = BorderStyle.None;
                    break;
                case BorderStyles.Thin:
                    style = BorderStyle.Thin;
                    break;
                case BorderStyles.Medium:
                    style = BorderStyle.Medium;
                    break;
                case BorderStyles.Thick:
                    style = BorderStyle.Thick;
                    break;
                case BorderStyles.Dotted:
                    style = BorderStyle.Dotted;
                    break;
                case BorderStyles.Dashed:
                    style = BorderStyle.Dashed;
                    break;
                case BorderStyles.Double:
                    style = BorderStyle.Double;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(borderStyle), borderStyle, null);
            }

            for (int i = startRowIndex; i <= endRowIndex; i++)
            {
                IRow row = _currentSheet.GetRow(i);
                for (int j = startColIndex; j <= endColIndex; j++)
                {
                    ICell cell = row.GetCell(j);
                    if (cell == null)
                    {
                        cell = row.CreateCell(j);
                    }

                    ICellStyle cellStyle = cell.CellStyle;
                    cellStyle.BorderTop = style;
                    cellStyle.BorderBottom = style;
                    cellStyle.BorderLeft = style;
                    cellStyle.BorderRight = style;
                    cell.CellStyle = cellStyle;
                }
            }
        }

        //public virtual async Task AutoSizeColumns(int startRow, int startCol, int rows, int cols)
        //{
        //    for (int r = startRow; r < rows; r++)
        //    {
        //        for (int i = startCol; i < cols; i++)
        //        {
        //            _currentSheet.AutoSizeColumn(i);
        //        }
        //    }

        //    await Task.CompletedTask;
        //}
        //public virtual async Task<byte[]> WriteToMemoryStream()
        //{
        //    byte[] excelBytes = null!;
        //    using (var stream = new MemoryStream())
        //    {
        //        _workBook.Write(stream);
        //        excelBytes = stream.ToArray();
        //    }

        //    await Task.CompletedTask;
        //    return excelBytes;
        //}

        public virtual async Task<byte[]> WriteToMemoryStream()
        {
            byte[] excelBytes = await File.ReadAllBytesAsync(_excelFilePath);
            return excelBytes;
        }

        public virtual async Task Save()
        {
            // Save the file
            using (FileStream file = new FileStream(_excelFilePath, FileMode.Create))
            {
                _workBook.Write(file);
                file.Close();
            }

            await Task.CompletedTask;
        }
    }
}
