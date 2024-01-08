using SeedingLibrary.Classes;
using SeedingLibrary.Data;

using static SeedingFrontendApp.Classes.SpectreConsoleHelpers;

namespace SeedingFrontendApp;

internal partial class Program
{
    static void Main(string[] args)
    {

        CreatePopulate();
        ReadData();

        ExitPrompt();
    }

    private static void ReadData()
    {
        PrintCyan();
        using var context = new Context();
        var results = context.Customer.ToList();
        AnsiConsole.MarkupLine($"There are [white]{results.Count}[/] customers.");
    }

    static void CreatePopulate()
    {
        PrintCyan();
        using var context = new Context();
        context.Database.EnsureDeleted();
        context.Database.EnsureCreated();
        context.AddRange(BogusOperations.CustomersListHasNoIdentifiers(50));
        context.SaveChanges();
    }
}