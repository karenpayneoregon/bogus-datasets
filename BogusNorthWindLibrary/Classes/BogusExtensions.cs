using Bogus;
using Bogus.Premium;
using BogusNorthWindLibrary.DataSets;

namespace BogusNorthWindLibrary.Classes;
public static class BogusExtensions
{
    /// <summary>
    /// Entry point for faker RuleFor
    /// </summary>
    public static NorthWind NorthWind(this Faker faker) 
        => ContextHelper.GetOrSet(faker, () => new NorthWind());
}