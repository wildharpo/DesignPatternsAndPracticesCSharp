using DesignPatterns.Library.Patterns.Creational.FactoryMethod;
using DesignPatterns.Library.Patterns.Creational.FactoryMethod.Implementations;

namespace DesignPatterns.Console.TestDrivers.Creational.Factory
{
    public static class FactoryTestDriver
    {
        public static void RunTestWithMyApplication()
        {
            Application myOtherApplication = new ExcelApplication();
            myOtherApplication.NewDocument();
            myOtherApplication.OpenDocument();
        }

        public static void RunTestWithExcelApplication()
        {
            Application myOtherApplication = new ExcelApplication();
            myOtherApplication.NewDocument();
            myOtherApplication.OpenDocument();
        }
    }
}
