using Week8.task_1;
using Week8.task_2;
using Week8.task_3;

Console.WriteLine("=== Running Task 1 ===");
Task1.Run();

Console.WriteLine("\n=== Running Task 2 ===");
Task2.Run();

Console.WriteLine("\n=== Running Task 3 ===");


var container = new DataContainer<DataItem>();
for (int i = 0; i < 10000; i++)
{
    var item = new DataItem
    {
        Id = $"item-{i}",
        Payload = new byte[1024]
    };
    container.AddItem(item);
}
Console.WriteLine($"Total size before GC: {container.GetTotalSize()} bytes");
GC.Collect();
Console.WriteLine("GC.Collect() was called.");
Console.WriteLine($"Total size after GC: {container.GetTotalSize()} bytes");