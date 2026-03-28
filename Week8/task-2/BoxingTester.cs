namespace Week8.task_2;

public static class BoxingTester
{
    public static void Test()
    {
        int a = 10; // creating new int
        
        object b = a; //coping from stack to heap
        int c = (int)b; //pulling value from obj in heap to stack as int
        
        Console.WriteLine($"origin int a: {a}");
        Console.WriteLine($"boxed object b: {b}");
        Console.WriteLine($"unboxed int c: {c}");
    }
}
