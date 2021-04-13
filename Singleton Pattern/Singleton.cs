using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Pattern
{
    //sealed restrict the inheritance
    public sealed class  Singleton
    {
        private static int counter = 0;
       
        //private constructor ensures that object is not instantiated other than within the class itself
        private Singleton()
        {
            counter++;
            Console.WriteLine($"Counter Value {counter.ToString()}");
        }

        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(()=>new Singleton());

        //public  property is used to return only one instance of the class leveraging on the private property
        public static Singleton GetInstance
        {
            get
            {
                return instance.Value;
            }
        }

        //Public method which can be invoked through the singleton instance
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
