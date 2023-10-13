namespace Dependency_Inversion;

public interface IMessage
{
    public string? Body { get; set; }

    public void Send();

    public void Write();

    public void Delete();
}