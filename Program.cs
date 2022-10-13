using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace IronPythonProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 200;

            ScriptEngine engine = Python.CreateEngine();
            //engine.Execute("print('Hello NET from Iron Python!')");
            ScriptScope scope = engine.CreateScope();

            //scope.SetVariable("b", num);
            //engine.ExecuteFile("../../../prog.py", scope);

            //dynamic x = scope.GetVariable("a");
            //dynamic y = scope.GetVariable("c");

            //Console.WriteLine($"{x} + {num} = {y}");

            int number = 1000;
            engine.ExecuteFile("../../../prog.py", scope);
            dynamic sum = scope.GetVariable("GaussSum");
            Console.WriteLine(sum.GetType());

            dynamic result = sum(number);
            Console.WriteLine(result);
        }
    }
}