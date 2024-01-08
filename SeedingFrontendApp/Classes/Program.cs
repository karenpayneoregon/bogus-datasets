using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace SeedingFrontendApp;
internal partial class Program
{
    [ModuleInitializer]
    public static void Init()
    {
        Console.Title = "Seeding database for database";
        WindowUtility.SetConsoleWindowPosition(WindowUtility.AnchorWindow.Center);
    }
}
