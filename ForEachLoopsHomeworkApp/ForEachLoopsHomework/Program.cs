
string? data = null;
List<string> firstNames = new();

do
{
    Console.Write("Enter first name (Type exit to quit): ");
    data = Console.ReadLine();

    if (!String.IsNullOrEmpty(data) && data.ToLower() != "exit")
    {
        firstNames.Add(data);
        Console.WriteLine("Addded...");
    }
} while (data.ToLower() != "exit");

foreach (string firstName in firstNames)
{
    Console.WriteLine($"Hello {firstName}");
}
