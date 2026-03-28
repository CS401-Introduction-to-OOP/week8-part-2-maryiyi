namespace Week8;

public class FileResource : Resource, IDisposable
{
    public FileResource(string name) : base(name)
    {
    }
    
    public override void Open()
    {
        IsOpen = true;
    }
    public override void Close()
    {
        if (IsOpen)
        {
            IsOpen = false;
        }
    }
    public void Dispose()
    {
        Close();
        Console.WriteLine($"Close: {Name}");

    }
}