namespace DesignPatterns.Library.Patterns.Structural.Facade
{
    public class Compiler
    {
        public void Compile(MemoryStream inputStream, MemoryStream outputStream)
        {
            var scanner = new Scanner(inputStream);
            var programNodeBuilder = new ProgramNodeBuilder();
            var parser = new Parser();

            parser.Parse(scanner, programNodeBuilder);

            var codeGenerator = new RISCCodeGenerator(outputStream);
            var parseTree = programNodeBuilder.GetRootNode();
            parseTree.Traverse(codeGenerator);
        }
    }
}
