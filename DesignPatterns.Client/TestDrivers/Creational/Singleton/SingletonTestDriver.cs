namespace DesignPatterns.Console.TestDrivers.Creational.Singleton
{
    public static class SingletonTestDriver
    {
        public static void RunTest()
        {
            var account1 = DesignPatterns.Library.Patterns.Creational.Singleton.Singleton.Instance().LookupAccountBySsn(1321);
            var account2 = DesignPatterns.Library.Patterns.Creational.Singleton.Singleton.Instance().LookupAccountBySsn(0349);
            System.Console.WriteLine($"Account1 belongs to {account1.FirstName} {account1.LastName}");
            System.Console.WriteLine($"Account2 belongs to {account2.FirstName} {account2.LastName}");
        }
    }
}
