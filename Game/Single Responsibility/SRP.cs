using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Single_Responsibility
{
    public class Dog
    {
        private int age;
        private string name;

        public Dog()
        {
            age = 1;
            name = "멈뭄미";
        }

        public void Eat()
        {
            Console.WriteLine("Eat");
        }

        public void Walk()
        {
            Console.WriteLine("Walk");
        }

        public string Representation()
        {
            return $"Name : {name}, Age : {age}";
        }
    }

    public class Information
    {
        public void Show(Dog dog)
        {
            Console.WriteLine(dog.Representation());
        }
    }
}
