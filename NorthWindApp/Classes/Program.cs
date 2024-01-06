using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace NorthWindApp;
internal partial class Program
{
    [ModuleInitializer]
    public static void Init()
    {
        AnsiConsole.MarkupLine("");
        Console.Title = "Code sample";
        WindowUtility.SetConsoleWindowPosition(WindowUtility.AnchorWindow.Center);
    }
    private static Table CreateCategoryTable()
    {
        return new Table()
            .RoundedBorder().BorderColor(Color.LightSlateGrey)
            .AddColumn("[b]Id[/]")
            .AddColumn("[b]Name[/]")
            .AddColumn("[b]Description[/]")
            .AddColumn("[b]Size[/]")
            .Alignment(Justify.Center)
            .Title("[yellow]Categories[/]");
    }
}
