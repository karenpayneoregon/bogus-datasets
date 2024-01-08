# About

Provides setup for working with a database using EF Core. The project name would be different for a real application but here its here to match up with two other projects, BogusSeedingModelLibrary and SeedingFrontendApp.

In SeedingFrontendApp there is a method to seed the table with the exact same data via Bogus and read back the data.


The line `Seed = new Random(338);` ensures same data each time, if the value were to change from 338 and left, this will create a new data-set tha 338.

```csharp
public static List<Customer> CustomersListHasNoIdentifiers(int count, bool random = false)
{
    if (!random)
    {
        Seed = new Random(338);
    }

    var faker = new Faker<Customer>()
        .RuleFor(u => u.FirstName, f => f.Name.FirstName())
        .RuleFor(u => u.LastName, f => f.Name.LastName())
        .RuleFor(c => c.BirthDay, f => f.Person.DateOfBirth)
        .RuleFor(e => e.Email, (f, e) => f.Internet.Email(e.FirstName, e.LastName))
        .RuleFor(c => c.Gender, f => f.PickRandom<Gender>());


    return faker.Generate(count);

}
```