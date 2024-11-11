using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.Patterns.Structural.Facade
{
    public class RISCCodeGenerator : CodeGenerator
    {
        public RISCCodeGenerator(MemoryStream memoryStream) : base(memoryStream)
        {
        }

        public override void Visit(StatementNode statementNode)
        {
            throw new NotImplementedException();
        }

        public override void Visit(ExpressionNode expressionNode)
        {
            throw new NotImplementedException();
        }
    }
}
