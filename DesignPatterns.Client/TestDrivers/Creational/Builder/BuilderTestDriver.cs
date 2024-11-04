using DesignPatterns.Library.Patterns.Creational.Builder;
using DesignPatterns.Library.Patterns.Creational.Builder.TextConverters;

namespace DesignPatterns.Client.TestDrivers.Creational.Builder
{
    public static class BuilderTestDriver
    {
        public static void RunTest()
        {
            var textConverter = new ASCIIConverter();
            var rtfReader = new RTFReader(textConverter);
            rtfReader.ParseRTF();
            System.Console.WriteLine(textConverter.GetASCIIText());
        }
    }
}
