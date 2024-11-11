namespace DesignPatterns.Library.Patterns.Structural.Facade
{
    public class Token
    {
        private char _character;

        public Token(char character)
        {
            _character = character;
        }

        public override string ToString()
        {
            return _character.ToString();
        }

        public char GetToken()
        {
            return _character;
        }
    }
}
