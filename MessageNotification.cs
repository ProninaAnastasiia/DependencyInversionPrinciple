namespace Dependency_Inversion;

public class MessageNotification
{
    private Message Message;

    public MessageNotification(Message message)
    {
        Message = message;
    }

    public void SendNotification()
    {
        Console.WriteLine("Сообщение: "+Message.Body);
    }
}