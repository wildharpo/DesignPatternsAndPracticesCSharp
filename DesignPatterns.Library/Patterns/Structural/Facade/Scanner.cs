namespace DesignPatterns.Library.Patterns.Structural.Facade
{
    public class Scanner
    {
        private MemoryStream _inputStream;

        public Scanner(MemoryStream inputStream)
        {
            _inputStream = inputStream;
        }

        public Token Scan() 
        {
            var byteArray = new byte[1];
            _inputStream.Read(byteArray, Convert.ToInt32(_inputStream.Position), 1);
            return new Token(byteArray[0].ToString()[0]); 
        }
    }
}
