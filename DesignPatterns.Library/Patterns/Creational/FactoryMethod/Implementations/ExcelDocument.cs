using OfficeOpenXml;
using System.Diagnostics;

namespace DesignPatterns.Library.Patterns.Creational.FactoryMethod.Implementations
{
    public class ExcelDocument : Document
    {
        private string _fileName;
        private ProcessStartInfo _processStartInfo;
        private ExcelPackage _excelPackage;
        private bool _docIsOpen;

        public ExcelDocument(string fileName, ProcessStartInfo processStartInfo)
        {
            _fileName = fileName;
            _processStartInfo = processStartInfo;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            _excelPackage = new ExcelPackage();
        }

        public override void Close()
        {
            _excelPackage.Dispose();
            _docIsOpen = false;
        }

        public override void Open()
        {
            // If the document is already open, ignore call
            if (_docIsOpen)
                return;

            _excelPackage.Workbook.Worksheets.Add("Sheet1");
            var bin = _excelPackage.GetAsByteArray();
            File.WriteAllBytes(_fileName, bin);

            var proc = new Process();
            proc.StartInfo = _processStartInfo;
            proc.Start();

            _docIsOpen = true;
        }
    }
}
