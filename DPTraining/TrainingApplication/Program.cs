using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPTraining.Builder;

namespace TrainingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Builder();
            Console.ReadKey();
        }

        private static void Builder()
        {
            TrainingBuilder builder = new TrainingBuilder();
            Console.WriteLine("name:");
            string name = Console.ReadLine();
            builder.AddName(name);
            Console.WriteLine("value:");
            string value = Console.ReadLine();
            builder.AddValue(value);
            Console.WriteLine(builder.GetProduct());
        }
    }
}
