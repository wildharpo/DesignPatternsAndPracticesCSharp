namespace DesignPatterns.Library.Patterns.Creational.Singleton
{
    public class Account
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int LastFourSsn { get; set; }

        public Account() {}

        public Account(string firstName, string lastName, string streetAddress, string city, string state, int lastFourSsn)
        {
            FirstName = firstName;
            LastName = lastName;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            LastFourSsn = lastFourSsn;
        }
    }
}
