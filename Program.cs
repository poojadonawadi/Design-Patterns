// See https://aka.ms/new-console-template for more information
using Design_Patttern_Practice;

//Console.WriteLine("Singleton Design Pattern");

//Singleton s1 = Singleton.GetInstance;
//s1.PrintMessage("hello");
//Singleton s2 = Singleton.GetInstance;
//s2.PrintMessage("hii");

//Console.WriteLine("Factory Design Pattern");

//ShapeFactory factory = new ShapeFactory();

//IShape shape1 = factory.GetShape("Circle");
//shape1.Draw();

//IShape shape2 = factory.GetShape("Rectangle");
//shape2.Draw();

NotificationFactory factory2 = new NotificationFactory();

INotification notiffication1 = factory2.FactoryNotify("Email");
notiffication1.GetNotify("This is an email notification");

INotification notiffication2 = factory2.FactoryNotify("SMS");
notiffication2.GetNotify("This is an SMS notification");

INotification notiffication3 = factory2.FactoryNotify("Push");
notiffication3.GetNotify("This is an Push notification");