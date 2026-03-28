namespace Week8.task_2;

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }
    
    public void Print()
    {
        Console.WriteLine($"{(X,Y)}"); 
    }
}