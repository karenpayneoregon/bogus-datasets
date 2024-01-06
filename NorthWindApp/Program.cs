using BogusNorthWindLibrary.Classes;
using BogusNorthWindLibrary.DataSets;
using BogusNorthWindLibrary.Models;
using static NorthWindApp.Classes.SpectreConsoleHelpers;

namespace NorthWindApp;

internal partial class Program
{
    static void Main(string[] args)
    {
        ContactListSample();
        SingleCategorySample();
        ExitPrompt();
    }

    private static void ContactListSample()
    {
        AnsiConsole.MarkupLine("[cyan]Contact[/]");
        Contact contact = NorthWind.SingleContact();
        Console.WriteLine(ObjectDumper.Dump(contact));
    }

    // ObjectDumper does not handle BitMap
    private static void SingleCategorySample()
    {
        var table = CreateCategoryTable();

        Categories category = NorthWind.SingleCategory();
        table.AddRow(category.CategoryID.ToString(), category.CategoryName, category.Description, category.Picture.Size.ToString());
        AnsiConsole.Write(table);


    }
}