using ConsoleApp1.Interface;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAdd a = new Calculate();
            Console.WriteLine(a.Add(23,22));
            IDivide b = new Calculate();
            Console.WriteLine(b.Divide(22,11));
        }
    }
}
