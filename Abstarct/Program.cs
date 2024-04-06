using Abstarct.Models;

namespace Abstarct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(4,false,"AMG","GLS63","Dark Green",2,200);
            Bicycle bicycle = new Bicycle("race","stels","stels","red",1,60);
            car.AverageSpeed();
            car.DefineNatureHarmness();
            car.ToString();
            car.GetInfo();
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            bicycle.AverageSpeed();
            bicycle.DefineNatureHarmness();
            bicycle.ToString();
            bicycle.GetInfo();
        }
    }
}
