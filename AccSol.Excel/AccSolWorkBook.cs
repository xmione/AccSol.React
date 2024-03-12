namespace AccSol.Excel
{
    public class AccSolWorkBook: AWorkBook
    {
        public AccSolWorkBook(string sheetName)
        {
            CreateExcelFile(sheetName).Wait();
        }
        public AccSolWorkBook(string excelFilePath, string sheetName) 
        {
            CreateExcelFile(excelFilePath, sheetName).Wait();
        }
    }
}
