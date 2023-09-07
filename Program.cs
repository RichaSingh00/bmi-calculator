using PersonApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(1, "Jassie", 23, 5.3, 45);
            Person person2 = new Person(2, "Stacy", 25);

            Console.WriteLine("BMI for "+person1.GetName+" is:"+person1.CalculateTheBMI()+" and " +
                "their BodyType is:"+person1.GetBodyType());
            Console.WriteLine("BMI for " + person2.GetName + " is:" + person2.CalculateTheBMI() + 
                " and their BodyType is:" + person2.GetBodyType());

        }
    }
}
