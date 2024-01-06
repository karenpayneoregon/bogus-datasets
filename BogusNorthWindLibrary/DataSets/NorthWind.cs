using System.Text.Json;
using Bogus;
using BogusNorthWindLibrary.Classes;
using BogusNorthWindLibrary.Models;
using ImageHelperLibrary;

namespace BogusNorthWindLibrary.DataSets;

/// <summary>
/// Bogus DataSet for using NorthWind2024 data
/// </summary>
public class NorthWind : DataSet
{

    private static Categories RandomCategory => System.Random.Shared.GetItems(categories()!.ToArray(), 1)[0];

 
    public static Categories SingleCategory() 
        => RandomCategory;

    private static List<Categories>? categories()
    {
        List<Categories>? list = JsonSerializer.Deserialize<List<Categories>>(JsonStatements.CategoriesData);

        foreach (var cat in list!)
        {
            cat.Picture = cat.Photo.ByteToImage();
        }

        return list;
    }

    public static ContactType GetContactType(int id) 
        => JsonSerializer.Deserialize<List<ContactType>>(JsonStatements.ContactTypeData)!.FirstOrDefault(x => x.ContactTypeIdentifier == id)!;

    public static Contact SingleContact()
    {
        var contact = System.Random.Shared.GetItems(JsonSerializer.Deserialize<List<Contact>>(JsonStatements.ContactData)!.ToArray(), 1)[0];
        var contactType = GetContactType(contact.ContactTypeIdentifier);
        contact.ContactType = contactType;

        return contact;
    }

    /// <summary>
    /// Pre-defined contact titles
    /// </summary>
    private static string[] contactTitles { get; } = [
        "Accounting Manager",
        "Assistant Sales Agent",
        "Assistant Sales Representative",
        "Marketing Assistant",
        "Marketing Manager",
        "Order Administrator",
        "Owner",
        "Owner/Marketing Assistant",
        "Sales Agent",
        "Sales Associate",
        "Sales Manager",
        "Sales Representative",
        "Vice President, Sales"
    ];

    public string ContactTypeNames()
        => Random.ArrayElement(contactTitles);
    public ContactType ContactTypes()
    {
        var data = new Faker<ContactType>()
            .RuleFor(p => p.ContactTypeIdentifier, p => p.Random.Int(1, 10))
            .RuleFor(p => p.ContactTitle, f => f.NorthWind().ContactTypeNames());

        return data.Generate();

    }

}