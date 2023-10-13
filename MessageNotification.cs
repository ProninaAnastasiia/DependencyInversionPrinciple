namespace Dependency_Inversion;

public class MessageNotification
{
    private IMessage Message;

    public MessageNotification(IMessage message)
    {
        Message = message;
    }

    public void SendNotification()
    {
        Console.WriteLine("Сообщение: "+Message.Body);
    }
}