using System.Drawing;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace BogusNorthWindLibrary.Models;

public class Categories
{
    public int CategoryID { get; set; }
    public string CategoryName { get; set; }
    public string Description { get; set; }
    public byte[] Photo { get; set; }
    public Bitmap Picture { get; set; }
}