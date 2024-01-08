using Bogus;
using SeedingPersonApp.Models;
using static Bogus.Randomizer;

namespace SeedingPersonApp.Classes;

    internal class BogusOperations
    {
        public static List<Human> HumanList(int count = 2)
        {
            Seed = new Random(1338);
            var id = 1;
            var faker = new Faker<Human>()
                .RuleFor(h => h.Id, f => id++)
                .RuleFor(h => h.FirstName, f => f.Person.FirstName)
                .RuleFor(h => h.LastName, f => f.Person.LastName);

            return faker.Generate(count);
        }
    }
