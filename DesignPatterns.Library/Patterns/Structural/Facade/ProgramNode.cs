using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.Patterns.Structural.Facade
{
    public abstract class ProgramNode
    {
        public abstract void GetSourcePosition(int line, int index);

        public abstract void Add(ProgramNode programNode);

        public abstract void Remove(ProgramNode programNode);

        public abstract void Traverse(CodeGenerator codeGenerator);
    }
}
