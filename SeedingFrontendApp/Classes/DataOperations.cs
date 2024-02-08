using SeedingLibrary.Data;

namespace SeedingFrontendApp.Classes;
internal class DataOperations
{
    private static Table CreateTable()
        => new Table().RoundedBorder().LeftAligned()
            .AddColumn("[cyan]Id[/]")
            .AddColumn("[cyan]First[/]")
            .AddColumn("[cyan]Last[/]")
            .AddColumn("[cyan]Birth[/]")
            .AddColumn("[cyan]Email[/]")
            .AddColumn("[cyan]Gender[/]")
            .BorderColor(Color.LightSlateGrey)
            .Border(TableBorder.Square)
            .Title("[LightGreen]Data[/]");

    public static void ReadData()
    {

        using var context = new Context();
        var results = context.Customer.ToList();

        Table table = CreateTable();
        
        foreach (var customer in results)
        {
            table.AddRow(
                customer.Id.ToString(), 
                customer.FirstName, 
                customer.LastName, 
                customer.BirthDay.ToString(), 
                customer.Email, 
                customer.Gender.ToString());
        }

        AnsiConsole.Write(table);
        AnsiConsole.MarkupLine($"There are [white]{results.Count}[/] customers.");
        Console.CursorVisible = false;
        Console.SetCursorPosition(0,0);
    }
}
