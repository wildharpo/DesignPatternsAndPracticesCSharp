using DesignPatterns.Library.Patterns.Structural.Proxy;
using DesignPatterns.Library.Patterns.Structural.Proxy.Support;

namespace DesignPatterns.Console.TestDrivers.Structural.Proxy
{
    public static class ProxyTestDriver
    {
        public static void RunTest()
        {
            var textDocument = new TextDocument();

            // create both an image and an image proxy. The image should load immediately, while the proxy does not 
            // load an image until explicitly asked.
            var image = new Image("C:\\Temp\\MyPhoto.jpg"); // image will be loaded immediately
            var imageProxy = new ImageProxy("C:\\Temp\\MyPhoto.jpg");  // loading deferred until explicitly called

            textDocument.Insert(image);
            textDocument.Insert(imageProxy);

            var drawingPoint = new Point();
            image.Draw(drawingPoint);
            imageProxy.Draw(drawingPoint);
        }
    }
}
