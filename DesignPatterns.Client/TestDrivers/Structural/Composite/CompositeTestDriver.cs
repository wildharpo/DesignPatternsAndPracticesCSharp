using DesignPatterns.Library.Patterns.Structural.Composite;
using DesignPatterns.Library.Patterns.Structural.Decorator;

namespace DesignPatterns.Console.TestDrivers.Structural.Composite
{
    public class CompositeTestDriver
    {
        public static void RunTest()
        {
            // A Picture object should be able to contain both simple objects (lines, rectangles, text) and composite objects
            // (i.e. another Picture object).
            // Create a new picture
            System.Console.WriteLine("Creating a picture object...");
            var picture = new Picture();

            // Add simple objects
            System.Console.WriteLine("Adding a line, rectangle, and text to the picture object...");
            picture.Add(new Line());
            picture.Add(new Rectangle());
            picture.Add(new Text());

            // Create a second picture object and add a rectangle to it
            System.Console.WriteLine("Creating a secondary picture object...");
            var subPicture = new Picture();
            subPicture.Add(new Rectangle());

            // Add the second picture object to the first
            System.Console.WriteLine("Adding the secondary picture object to the original picture object...");
            picture.Add(subPicture);

            // Now retrive the added secondary picture from the first picture object
            var secondaryPicture = picture.GetChild(3);
            System.Console.WriteLine("Verifying secondary picture object is now a child of the first picture object...");
            if (secondaryPicture.GetType() == typeof(Picture))
                System.Console.WriteLine("Verification succeeded!");
            else
                System.Console.WriteLine("Verification failed...");
        }

        //public static void RunTest2()
        //{
        //    var textView = new TextView();
        //    var scrollDecorator = new ScrollDecorator(textView);
        //    var borderDecorator = new BorderDecorator(scrollDecorator);
        //}
    }
}
