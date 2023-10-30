using Dependency_Inversion;

Message a = new Message();
a.Write();
a.Send();
MessageNotification mn = new MessageNotification(a);
mn.SendNotification();
