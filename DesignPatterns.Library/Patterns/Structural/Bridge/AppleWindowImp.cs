using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.Patterns.Structural.Bridge
{
    public class AppleWindowImp : WindowImp
    {
        public override void DevDrawLine()
        {
            throw new NotImplementedException();
        }

        public override void DevDrawText()
        {
            throw new NotImplementedException();
        }
    }
}
