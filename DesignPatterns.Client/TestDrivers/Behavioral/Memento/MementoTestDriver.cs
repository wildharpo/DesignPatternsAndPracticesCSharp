using DesignPatterns.Library.Patterns.Behavioral.Memento;

namespace DesignPatterns.Console.TestDrivers.Behavioral.Memento
{
    public static class MementoTestDriver
    {
        public static void RunTest()
        {
            var originator = new Originator(1);
            var caretaker = new Caretaker(originator);

            caretaker.Backup();
            originator.DoSomething();

            caretaker.Backup();
            originator.DoSomething();

            caretaker.Backup();
            originator.DoSomething();

            caretaker.ShowHistory();

            caretaker.Undo();

            caretaker.ShowHistory();

            caretaker.Undo();

            caretaker.ShowHistory();
        }
    }
}
