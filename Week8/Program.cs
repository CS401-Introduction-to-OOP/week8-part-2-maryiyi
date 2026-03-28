
using Week8;

var file = new FileResource("report.txt");
var network = new NetworkResource("api.company.local");
var manager = new ResourceManager<Resource>();
// TODO:
// 1. Add resources to manager
manager.Add(file);
manager.Add(network);

// 2. Open all resources
manager.OpenAll();

// 3. Demonstrate using with one disposable resource
using (var f = new FileResource("fldfjk.txt"))
{
    f.Open();
    Console.WriteLine($"open: {f.Name}");
}

// 4. Close all resources
manager.CloseAll();

Console.WriteLine("Done.");