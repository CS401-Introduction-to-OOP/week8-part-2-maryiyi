
using Week8.task_2;
public static class Task2
{
    public static void Run()
    {
        Point p1 = new Point { X = 1, Y = 2 };
        Point p2 = p1; // creating copy of p1 value to p2

// TODO: modify p2 and print both p1 and p2
        p2.Y = 10; // modifing only copu of y coordinate of p2 obj
        Console.WriteLine($"p1: {p1.X}, {p1.Y}"); //  (1, 2)
        Console.WriteLine($"p2: {p2.X}, {p2.Y}"); //  (1, 10)

// Reference type demo
        PointRef r1 = new PointRef { X = 1, Y = 2 };
        PointRef r2 = r1; // coping only link, r1 and r2 point to the same obj in the heap

// TODO: modify r2 and print both r1 and r2
        r2.X = 5; // modifing obj, that is being pointed by both links
        Console.WriteLine($"r1: {r1.X}, {r1.Y}"); // (5, 2)
        Console.WriteLine($"r2: {r2.X}, {r2.Y}"); // (5, 2), because obj is the same

// Boxing demo
        BoxingTester.Test();

    }
}




