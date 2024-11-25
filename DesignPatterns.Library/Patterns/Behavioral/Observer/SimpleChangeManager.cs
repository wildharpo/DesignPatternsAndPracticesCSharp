namespace DesignPatterns.Library.Patterns.Behavioral.Observer
{
    public class SimpleChangeManager : ChangeManager
    {
        public override void Notify()
        {
            foreach(var registration in Registrations)
            {
                registration.Observer.Update(registration.Subject);
            }
        }

        public override void Register(Subject subject, Observer observer)
        {
            Registrations.Add(new SubjectObserverMapping(subject, observer));
        }

        public override void Unregister(Subject subject, Observer observer)
        {
            var matches = Registrations.Where(r => r.Subject == subject && r.Observer == observer).ToList();
            if (matches.Any())
                foreach (var match in matches)
                    Registrations.Remove(match);
        }
    }
}
