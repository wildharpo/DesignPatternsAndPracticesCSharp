using DesignPatterns.Library.Patterns.Structural.Facade;

namespace DesignPatterns.Console.TestDrivers.Structural.Facade
{
    public static class FacadeTestDriver
    {
        public static void RunTest()
        {
            var compiler = new Compiler();
            var inputStream = new MemoryStream();
            var outputStream = new MemoryStream();
            System.Console.WriteLine("Compiling source code...");
            try
            {
                compiler.Compile(inputStream, outputStream);
                System.Console.WriteLine("Compilation completed!");
            }
            catch(Exception ex)
            {
                System.Console.WriteLine($"Compilation failed. Error is '{ex}'");
            }
        }
    }
}
