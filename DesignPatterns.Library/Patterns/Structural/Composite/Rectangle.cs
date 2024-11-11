﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.Patterns.Structural.Composite
{
    public class Rectangle : Graphic
    {
        public override void Add(Graphic graphic)
        {
            throw new NotImplementedException();
        }

        public override void Draw()
        {
            // logic to draw a rectangle
        }

        public override Graphic GetChild(int index)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Graphic graphic)
        {
            throw new NotImplementedException();
        }
    }
}
