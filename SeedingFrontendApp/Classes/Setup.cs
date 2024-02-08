using SeedingLibrary.Classes;
using SeedingLibrary.Data;

namespace SeedingFrontendApp.Classes;

public static class Setup
{
    /// <summary>
    /// Recreate database with spinner
    /// </summary>
    public static void CleanStart()
    {
        using var context = new Context();
        AnsiConsole.Status()

            .Start("Setting up database...", ctx =>
            {

                Thread.Sleep(500);

                ctx.Spinner(Spinner.Known.Star);
                ctx.SpinnerStyle(Style.Parse("cyan"));

                ctx.Status("[green]Removing database[/]");
                context.Database.EnsureDeleted();

                ctx.Status("[yellow]Creating database[/]");
                context.Database.EnsureCreated();

                ctx.Status("[lime]Populating data[/]");
                Thread.Sleep(500);
                context.AddRange(BogusOperations.CustomersListHasNoIdentifiers(50));
                context.SaveChanges();
            });

    }
}