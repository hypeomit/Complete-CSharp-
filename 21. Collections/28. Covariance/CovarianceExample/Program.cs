using System;
using System.Collections.Generic;

namespace CovarianceExample
{
    class LivingThing //parent class
    {
        public int NumberOfLegs { get; set; }
    }

    class Parrot: LivingThing //child class
    {
    }

    class Dog: LivingThing//child class
    {
    }

    //interface with generic type
    //out keyword says that, you can use this generic parameter T only as return type of a method or property but not as a parameter type

  
    interface IMover<out T>
    {
        T Move();
        //T Move(T x) throws error, we cannot use T for parameter type
    }
    //generic class which implements the IMover<T>
    class Mover<T>: IMover<T>
    {
        public T thing { get; set; }
       
        public T Move()
        {
            return thing;//returning T type 
        }
    }

    class Sample
    {
        public void PrintValues(IEnumerable<object> values)
        {
            foreach (var item in values)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main()
        {
            //create object
            //here an object of the parent class is expected but we have supplying the object of child class 
            LivingThing livingThing = new Parrot(); //not covariance, this is just a normal behvaiour expected in inheritance
            Parrot parraot = new Parrot() { NumberOfLegs = 2 }; //normal

            //but covariance is implemented with generics,  you required to have interface with generic type parameter 
            // Covariance = supply the child type name, where the parent type name is expected.
            //LivingThing vs Parrot(child vs parent)
            //out keyword = covariance, in = contravariance
            //we use out keyword in interface 
            IMover<LivingThing> mover = new Mover<Parrot>() { thing = parraot };  
            Console.WriteLine("Moving with " + mover.Move().NumberOfLegs + " legs"); //"LivingThing" vs "Parrot"; supplying the child type (Parrot), where the parent type (LivingThing) is expected


            //Covariance in real life
            Sample s = new Sample();
            s.PrintValues(new List<string>() { "hello", "world" });

            Console.ReadKey();
        }
    }
}
