using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patttern_Practice
{
    internal class NotificationFactory
    {
        public INotification FactoryNotify(string notificatonType)
        {
            if(notificatonType == "Email")
            {
                return new EmailNotification();
            }
            else if(notificatonType == "SMS")
            {
                return new SMSNotification();
            }
            else if(notificatonType == "Push")
            {
                return new PushNotification();
            }
            return null;
        }
    }
}
