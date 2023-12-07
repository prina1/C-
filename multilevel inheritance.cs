using System;
using System.Security.Cryptography.X509Certificates;

namespace Inheritance{
    internal class Program{
        public class Animal{
            public void Eat(){
                Console.WriteLine("Animal is eating");
            }
        }
        public class Mammal: Animal {
            public void GiveBirth(){
                Console.WriteLine("Mammal is giving birth");
            }
        }
        //Final Derived Class
        public class Dog: Mammal{
            public void Bark(){
                Console.WriteLine("Dog is barking");
            }
        }

        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.GiveBirth();
            dog.Bark();
        }
    }
}