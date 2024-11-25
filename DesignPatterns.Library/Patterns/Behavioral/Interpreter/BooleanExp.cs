using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.Patterns.Behavioral.Interpreter
{
    public abstract class BooleanExp
    {
        public abstract bool Evaluate(Context context);
        public abstract BooleanExp Replace(char character, BooleanExp booleanExp);
        public abstract BooleanExp Copy();
    }
}
