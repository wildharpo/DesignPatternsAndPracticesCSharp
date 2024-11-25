using DesignPatterns.Library.Patterns.Behavioral.Mediator;

namespace DesignPatterns.Console.TestDrivers.Behavioral.Mediator
{
    public static class MediatorTestDriver
    {
        public static void RunTest()
        {
            var fontDialogDirector = new FontDialogDirector();
            fontDialogDirector.CreateWidgets();
            var entryField = (EntryField)fontDialogDirector.Widgets.First(w => w.GetType() == typeof(EntryField));
            var listBox = (ListBox)fontDialogDirector.Widgets.First(w => w.GetType() == typeof(ListBox));
            System.Console.WriteLine($"Current entry field value is '{entryField.Text}'");
            listBox.SelectItem(2);
            System.Console.WriteLine($"After new list box item selected, current entry field value is '{entryField.Text}'");
        }
    }
}
