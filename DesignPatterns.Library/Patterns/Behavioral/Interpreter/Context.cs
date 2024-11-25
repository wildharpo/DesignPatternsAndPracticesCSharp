using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.Patterns.Behavioral.Interpreter
{
    public class Context
    {
        private Dictionary<VariableExp, bool> _variableValues;

        public Context()
        {
            _variableValues = new Dictionary<VariableExp, bool>();
        }

        public bool Lookup(char character)
        {
            if (!_variableValues.Any(v => v.Key.Name == character))
                return false;

            var match = _variableValues.First(v => v.Key.Name == character);
                return match.Value;
        }

        public void Assign(VariableExp variableExp, bool trueOrFalse)
        {
            if (_variableValues.ContainsKey(variableExp))
                _variableValues[variableExp] = trueOrFalse;
            else
                _variableValues.Add(variableExp, trueOrFalse);
        }
    }
}
