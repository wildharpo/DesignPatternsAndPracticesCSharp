using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.Patterns.Behavioral.Command
{
    public class Receiver
    {
        private Action _action;

        public Action Action { get { return _action; } }

        public void SetAction(Action action)
        {
            _action = action;
        }
    }
}
