using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.Patterns.Structural.Bridge
{
    public class PMWindowImp : WindowImp
    {
        public override void DevDrawLine()
        {
            //PMDrawLine();
        }

        public override void DevDrawText()
        {
            //PMDrawString();
        }
    }
}
