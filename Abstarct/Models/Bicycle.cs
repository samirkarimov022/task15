using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstarct.Models
{
    internal class Bicycle : Vehicle
    {
        public string Type;
        public Bicycle(string type,string factoryName, string model, string color, int driveTime, double drivePath) : base(factoryName, model, color, driveTime, drivePath)
        {
            Type = type;
        }

        public override void DefineNatureHarmness()
        {
            Console.WriteLine("no damage");
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"type: {Type}");
        }
    }
}
