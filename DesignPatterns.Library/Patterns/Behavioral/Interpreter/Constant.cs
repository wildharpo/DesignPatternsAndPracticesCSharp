namespace DesignPatterns.Library.Patterns.Behavioral.Interpreter
{
    public class Constant : BooleanExp
    {
        private bool _boolean;

        public Constant(bool boolean)
        {
            _boolean = boolean;
        }

        public override BooleanExp Copy()
        {
            return new Constant(_boolean);
        }

        public override bool Evaluate(Context context)
        {
            return _boolean;
        }

        public override BooleanExp Replace(char character, BooleanExp booleanExp)
        {
            throw new NotImplementedException();
        }
    }
}
