namespace DesignPatterns.Library.Patterns.Creational.Singleton
{
    public class AccountService
    {
        private readonly List<Account> _accounts;

        public AccountService()
        {
            var account1 = new Account("Matt", "Jones", "1234 Some Street", "Springfield", "MO", 1321);
            var account2 = new Account("John", "Smith", "339 Cowpunch Street", "Hollister", "MO", 0349);
            var account3 = new Account("Rick", "James", "444 Wicker Ave", "Ozark", "MO", 4493);
            _accounts = new List<Account>();
            _accounts.Add(account1);
            _accounts.Add(account2);
            _accounts.Add(account3);
        }

        public Account LookupAccountBySsn(int lastFourSsn)
        {
            return _accounts.FirstOrDefault(a => a.LastFourSsn == lastFourSsn);
        }
    }
}
