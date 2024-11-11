using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.Patterns.Structural.Facade
{
    public class VariableNode : ProgramNode
    {
        public override void Add(ProgramNode programNode)
        {
            throw new NotImplementedException();
        }

        public override void GetSourcePosition(int line, int index)
        {
            throw new NotImplementedException();
        }

        public override void Remove(ProgramNode programNode)
        {
            throw new NotImplementedException();
        }

        public override void Traverse(CodeGenerator codeGenerator)
        {
            throw new NotImplementedException();
        }
    }
}
