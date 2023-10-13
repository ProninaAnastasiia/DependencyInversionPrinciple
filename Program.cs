// See https://aka.ms/new-console-template for more information

using Dependency_Inversion;

Message a = new Message();
a.Write();
a.Send();
Console.WriteLine("Hello, World!");
MessageNotification mn = new MessageNotification(a);
mn.SendNotification();
