using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cat cat = new Cat("Кошка");

            Console.WriteLine(cat.Say());
            Console.ReadKey();

            Dog dog = new Dog("Собака");
            Console.WriteLine(dog.Say());

            Console.ReadKey();
        }
    }

    abstract class Animals
    {


        public abstract string Name { get; set; }

        public Animals()
        {

        }

        public abstract string Say();

        public string ShowInfo()
        {

            
            return Name+ Say();

           
        }


    }

    class Cat: Animals
    {
        string name;

        public override string Name
        {
            set
            {
                name = value;



            }


            get 
            {
                return name;
            
            
            }

        }


       public Cat (string name) 
        {
            Name = name;
        
        
        }


        public override string Say()
        {
            
            return name + " \t Мяу" ;

        }
    }


    class Dog:Animals 
    
    {
        string name;
        public override string Name
        {
            get
            {
                return name;

            }


            set
            {
                name = value;

            }

        }
        public Dog (string name)
        {
            Name = name;
        }
        public override string Say()
        {

            return name + " \t Гав";

        }


    }

}
