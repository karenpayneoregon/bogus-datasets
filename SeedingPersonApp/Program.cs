using SeedingPersonApp.Classes;

namespace SeedingPersonApp;

internal partial class Program
{
    static void Main(string[] args)
    {
        for (int index = 1; index < 4; index++)
        {
            AnsiConsole.MarkupLine($"[cyan]{index}{(index < 0 ? 
                "" : 
                (index % 100) switch { 11 or 12 or 13 => "th", var n => (n % 10) switch { 1 => "st", 2 => "nd", 3 => "rd", _ => "th" } })} set[/]");

            var list = BogusOperations.HumanList();
            Console.WriteLine(ObjectDumper.Dump(list));
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}