// See https://aka.ms/new-console-template for more information

using Dependency_Inversion;

Sms a = new Sms();
a.Write();
a.Send();
MessageNotification mn = new MessageNotification(a);
mn.SendNotification();
