namespace DesignPatterns.Library.Patterns.Behavioral.Interpreter
{
    public class VariableExp : BooleanExp
    {
        private char _name;

        public VariableExp(char name)
        {
            _name = name;
        }

        public char Name { get { return _name; } }

        public override BooleanExp Copy()
        {
            return new VariableExp(_name);
        }

        public override bool Evaluate(Context context)
        {
            return context.Lookup(_name);
        }

        public override BooleanExp Replace(char character, BooleanExp booleanExp)
        {
            if (_name == character)
                return booleanExp.Copy();
            else
                return new VariableExp(_name);
        }
    }
}
