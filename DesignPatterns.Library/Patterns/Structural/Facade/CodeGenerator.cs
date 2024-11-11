using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.Patterns.Structural.Facade
{
    public abstract class CodeGenerator
    {
        protected MemoryStream _memoryStream { get; set; }
        public abstract void Visit(StatementNode statementNode);
        public abstract void Visit(ExpressionNode expressionNode);

        protected CodeGenerator(MemoryStream memoryStream) 
        { 
            _memoryStream = memoryStream;
        }
    }
}
