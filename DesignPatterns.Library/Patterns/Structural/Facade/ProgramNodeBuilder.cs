namespace DesignPatterns.Library.Patterns.Structural.Facade
{
    public class ProgramNodeBuilder
    {
        private ProgramNode _programNode;

        public ProgramNode NewVariable(char variableName) { return new VariableNode(); }
        public ProgramNode NewAssignment(ProgramNode variable, ProgramNode expression) { return new VariableNode(); }
        public ProgramNode NewReturnStatement(ProgramNode value) { return new StatementNode(); }
        public ProgramNode NewCondition(ProgramNode condition, ProgramNode truePart, ProgramNode falsePart) { return new ExpressionNode(); }
        // etc...
        public ProgramNode GetRootNode()
        {
            return new StatementNode();
        }
    }
}
