using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp.Model
{
    internal class Person
    {
        private readonly int _id;
        private readonly string _name;
        private readonly int _age;
        private double _height;
        private double _weight;
        public Person(int id, string name, int age)
        {
            _id = id;
            _name = name;
            _age = age;
            _height = 5;
            _weight = 50;
        }
        public Person(int id, string name, int age, double height, double weight) : this(id, name, age)
        {
            _height = height;
            _weight = weight;
        }
        public int GetId { get { return _id; } }
        public string GetName { get { return _name; } }
        public int GetAge { get { return _age; } }
        public double Height { get { return _height; } }
        public double Weight { get { return _weight; } }
        public double CalculateTheBMI()
        {
            return (_weight / _height/ _height)*10;
        }
        public string GetBodyType()
        {
            double bmi = CalculateTheBMI();
            double underWeight = 18.5;
            double normalWeight = 25;
            double overWeight = 30;
            
            if (bmi < underWeight)
            {
                return "Underweight";
            }
            else if (bmi >= underWeight && bmi < normalWeight)
            {
                return "Normal";
            }
            else if (bmi >= normalWeight && bmi < overWeight)
            {
                return "Overweight";
            }
            else
            {
                return "Obese";
            }
        }
    }
}
