using DesignPatterns.Library.Patterns.Structural.Proxy.Support;

namespace DesignPatterns.Library.Patterns.Structural.Proxy
{
    public class ImageProxy : Graphic
    {
        private string _filePath;
        
        private Point _extent;
        private bool _isLoaded;
        private Image _image;

        public ImageProxy(string filePath)
        {
            _filePath = filePath;
            _extent = new Point();
            _isLoaded = false;
        }

        protected Image GetImage()
        {
            if(!_isLoaded)
            {
                _image = new Image(_filePath);
                _isLoaded = true;
            }
            return _image;
        }

        public override void Draw(Point point)
        {
            GetImage().Draw(point);
        }

        public override Point GetExtent()
        {
            if (_extent == null)
                _extent = GetImage().GetExtent();
            return _extent;
        }

        public override void HandleMouse(Event mouseEvent)
        {
            GetImage().HandleMouse(mouseEvent);
        }

        public override void Load(MemoryStream to)
        {
            GetImage().Load(to);
        }

        public override void Store(MemoryStream from)
        {
            GetImage().Store(from);
        }
    }
}
