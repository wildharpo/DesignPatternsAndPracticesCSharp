using System.Diagnostics;

namespace DesignPatterns.Library.Patterns.Creational.FactoryMethod.Implementations
{
    public class ExcelApplication : Application
    {
        private ProcessStartInfo _processStartInfo;
        private const string TEMP_FILE_NAME = "C:\\Users\\wildh\\MyTempFile.xlsx";

        public ExcelApplication()
        {
            _processStartInfo = new ProcessStartInfo(TEMP_FILE_NAME)
            {
                UseShellExecute = true
            };
        }

        public override Document CreateDocument()
        {
            var excelDocument = new ExcelDocument(TEMP_FILE_NAME, _processStartInfo);
            return excelDocument;
        }
    }
}
