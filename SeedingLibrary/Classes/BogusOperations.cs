using Bogus;
using Bogus.DataSets;
using BogusSeedingModelLibrary.Models;

using static Bogus.Randomizer;

namespace SeedingLibrary.Classes;

public class BogusOperations
{


    public static List<Customer> CustomersListHasIdentifiers(int count, bool random = false)
    {
        if (!random)
        {
            Seed = new Random(338);
        }

        var id = 1;

        var faker = new Faker<Customer>()
            .RuleFor(c => c.Id, f => id++)
            .RuleFor(u => u.FirstName, f => f.Name.FirstName())
            .RuleFor(u => u.LastName, f => f.Name.LastName())
            .RuleFor(c => c.BirthDay, f => f.Person.DateOfBirth)
            .RuleFor(e => e.Email, (f, e) => f.Internet.Email(e.FirstName, e.LastName))
            .RuleFor(c => c.Gender, f => f.PickRandom<Gender>());

        return faker.Generate(count);

    }
    public static List<Customer> CustomersListHasNoIdentifiers(int count, bool random = false)
    {
        if (!random)
        {
            Seed = new Random(338);
        }

        var faker = new Faker<Customer>()
            .RuleFor(u => u.Gender, f => f.PickRandom<Gender>())
            .RuleFor(c => c.FirstName, (f,u) => f.Name.FirstName((Name.Gender?)u.Gender))
            .RuleFor(c => c.LastName, f => f.Name.LastName())
            .RuleFor(c => c.BirthDay, f => f.Person.DateOfBirth)
            .RuleFor(e => e.Email, (f, e) => f.Internet.Email(e.FirstName, e.LastName))
            .RuleFor(c => c.Gender, f => f.PickRandom<Gender>());


        return faker.Generate(count);

    }
}
