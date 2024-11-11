using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.Patterns.Structural.Composite
{
    public abstract class Graphic
    {
        public abstract void Draw();
        public abstract void Add(Graphic graphic);
        public abstract void Remove(Graphic graphic);
        public abstract Graphic GetChild(int index);
    }
}
