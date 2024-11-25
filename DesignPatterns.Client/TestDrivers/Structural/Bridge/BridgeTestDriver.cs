using DesignPatterns.Library.Patterns.Structural.Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Console.TestDrivers.Structural.Bridge
{
    public static class BridgeTestDriver
    {
        public static void RunTest()
        {
            Window myWindow;
            var pmWindowImp = new PMWindowImp();
            myWindow = new IconWindow(pmWindowImp);
            Window myOtherWindow = new TransientWindow(pmWindowImp);
            myWindow.DrawRectangle();

        }
    }
}
