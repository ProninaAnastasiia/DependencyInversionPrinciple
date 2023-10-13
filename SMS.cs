namespace Dependency_Inversion;

public class Sms: IMessage
{
    private int MaxWordsCount { get; set; } = 50;
    public string? Body { get; set; }
    
    public void Send()
    {
        Console.WriteLine("Сообщение отправлено");
    }
    
    public void Write()
    {
        string m = Console.ReadLine();
        while(m.Length > MaxWordsCount)
        {
            Console.WriteLine("Сообщение слишком длинное");
            m = Console.ReadLine();
        }
        Body = m;
    }
    
    public void Delete()
    {
        Console.WriteLine("Сообщение удалено");
    }
}