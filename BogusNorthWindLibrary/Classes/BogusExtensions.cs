using Bogus;
using Bogus.Premium;
using BogusNorthWindLibrary.DataSets;

namespace BogusNorthWindLibrary.Classes;
public static class BogusExtensions
{
    /// <summary>
    /// Provides an extension method for the <see cref="Faker"/> class to access 
    /// the <see cref="NorthWind"/> dataset, enabling the generation of NorthWind-specific 
    /// fake data.
    /// </summary>
    /// <param name="faker">The <see cref="Faker"/> instance to extend.</param>
    /// <returns>An instance of the <see cref="NorthWind"/> dataset.</returns>
    /// <remarks>
    /// This method uses the <see cref="ContextHelper.GetOrSet{T}"/> method to ensure 
    /// that the <see cref="NorthWind"/> dataset is initialized and reused within the 
    /// context of the provided <see cref="Faker"/> instance.
    /// </remarks>
    public static NorthWind NorthWind(this Faker faker) 
        => ContextHelper.GetOrSet(faker, () => new NorthWind());
}