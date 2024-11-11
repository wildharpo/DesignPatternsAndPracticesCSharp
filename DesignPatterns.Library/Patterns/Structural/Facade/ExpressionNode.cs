namespace DesignPatterns.Library.Patterns.Structural.Facade
{
    public class ExpressionNode : ProgramNode
    {
        public override void Add(ProgramNode programNode)
        {
            throw new NotImplementedException();
        }

        public override void GetSourcePosition(int line, int index)
        {
            throw new NotImplementedException();
        }

        public override void Remove(ProgramNode programNode)
        {
            throw new NotImplementedException();
        }

        public override void Traverse(CodeGenerator codeGenerator)
        {
            codeGenerator.Visit(this);
        }
    }
}
