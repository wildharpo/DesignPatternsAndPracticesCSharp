using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.Patterns.Behavioral.Interpreter
{
    public class AndExp : BooleanExp
    {
        private BooleanExp _operand1;
        private BooleanExp _operand2;

        public AndExp(BooleanExp operand1, BooleanExp operand2)
        {
            _operand1 = operand1;
            _operand2 = operand2;
        }

        public override BooleanExp Copy()
        {
            return new AndExp(_operand1.Copy(), _operand2.Copy());
        }

        public override bool Evaluate(Context context)
        {
            return _operand1.Evaluate(context) && _operand2.Evaluate(context);
        }

        public override BooleanExp Replace(char character, BooleanExp booleanExp)
        {
            return new AndExp(_operand1.Replace(character, booleanExp), _operand2.Replace(character, booleanExp));
        }
    }
}
