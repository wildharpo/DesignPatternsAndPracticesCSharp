using DesignPatterns.Library.Patterns.Behavioral.Interpreter;

namespace DesignPatterns.Console.TestDrivers.Behavioral.Interpreter
{
    public static class InterpreterTestDriver
    {
        public static void RunTest()
        {
            BooleanExp expression;
            var context = new Context();

            var x = new VariableExp('X');
            var y = new VariableExp('Y');

            expression = new OrExp(new AndExp(new Constant(true), x), new AndExp(y, new NotExp(x)));

            context.Assign(x, false);
            context.Assign(y, true);

            var result = expression.Evaluate(context);
            System.Console.WriteLine($"Evaluation result is {result}");
        }
    }
}
