namespace DesignPatterns.Library.Patterns.Creational.Singleton
{
    public static class Singleton
    {
        private static AccountService _uniqueInstance;

        static Singleton()
        {
            _uniqueInstance = new AccountService();
        }

        public static AccountService Instance()
        {
            return _uniqueInstance;
        }
    }
}
