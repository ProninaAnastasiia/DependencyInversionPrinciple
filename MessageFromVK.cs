namespace Dependency_Inversion;

public class MessageFromVk: IMessage
{
    public string? Body { get; set; }

    public void Send()
    {
        Console.WriteLine("Сообщение отправлено");
    }
    
    public void Write()
    {
        Body = Console.ReadLine();
    }
    
    public void Delete()
    {
        Console.WriteLine("Сообщение удалено");
    }
}