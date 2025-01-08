using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patttern_Practice
{
    //sealed keyword is used to avoid the multiple instantiation by the inherited nested classes
    //which voilates the Singleton rules
    internal sealed class Singleton
    {
        private static Singleton Instance = null;
        private static readonly object lockObject = new object();
        private Singleton() { }

        //SIngle threaded environment
        //public static Singleton GetInstance
        //{
        //    get
        //    {
        //        if(Instance == null)
        //        {
        //            Instance = new Singleton();
        //        }
        //        return Instance;
        //    }

        //}

        //Multithreaded environment
        public static Singleton GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    lock (lockObject)
                    {
                        if (Instance == null)
                        {
                            Instance = new Singleton();
                        }
                    }
                }
                return Instance;
            }
        }
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
