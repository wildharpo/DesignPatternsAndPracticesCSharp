using DesignPatterns.Library.Patterns.Structural.Proxy.Support;
using Point = DesignPatterns.Library.Patterns.Structural.Proxy.Support.Point;

namespace DesignPatterns.Library.Patterns.Structural.Proxy
{
    public abstract class Graphic
    {
        public abstract void Draw(Point point);
        public abstract void HandleMouse(Event mouseEvent);
        public abstract Point GetExtent();
        public abstract void Store(MemoryStream from);
        public abstract void Load(MemoryStream to);
    }
}
