using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.Patterns.Behavioral.Observer
{
    public class PieChart : Observer
    {
        public int ObserverValue { get; private set; }

        public PieChart()
        {
            ObserverValue = 0;
        }

        public override void Update(Subject subject)
        {
            ObserverValue = subject.SubjectValue;
        }
    }
}
