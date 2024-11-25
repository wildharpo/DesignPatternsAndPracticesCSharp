using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.Patterns.Behavioral.Interpreter
{
    public class NotExp : BooleanExp
    {
        private BooleanExp _operand;

        public NotExp(BooleanExp operand)
        {
            _operand = operand;
        }

        public override BooleanExp Copy()
        {
            return new NotExp(_operand.Copy());
        }

        public override bool Evaluate(Context context)
        {
            return !_operand.Evaluate(context);
        }

        public override BooleanExp Replace(char character, BooleanExp booleanExp)
        {
            return new NotExp(_operand.Replace(character, booleanExp));
        }
    }
}
