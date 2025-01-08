using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patttern_Practice
{
    public class EmailNotification : INotification
    {
        public void GetNotify(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class SMSNotification : INotification
    {
        public void GetNotify(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class PushNotification : INotification
    {
        public void GetNotify(string message)
        {
            Console.WriteLine(message);
        }
    }
}
