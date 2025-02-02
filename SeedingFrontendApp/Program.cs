﻿using Microsoft.EntityFrameworkCore;
using SeedingFrontendApp.Classes;
using SeedingLibrary.Classes;
using SeedingLibrary.Data;

using static SeedingFrontendApp.Classes.SpectreConsoleHelpers;

namespace SeedingFrontendApp;

internal partial class Program
{
    static void Main(string[] args)
    {
        var customers = BogusOperations.CustomersListHasNoIdentifiers(500_000);

        Setup.CleanStart();
        Console.Clear();
        DataOperations.ReadData();
        
        ExitPrompt();
    }
}