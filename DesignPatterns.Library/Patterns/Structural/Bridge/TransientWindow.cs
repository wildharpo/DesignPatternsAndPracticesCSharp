using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.Patterns.Structural.Bridge
{
    public class TransientWindow : Window
    {
        public TransientWindow(WindowImp implementation) : base(implementation)
        {
        }

        public void DrawCloseBox()
        {
            base.DrawRectangle();
        }
    }
}
