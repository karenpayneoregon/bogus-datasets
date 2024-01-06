
namespace BogusNorthWindLibrary.Models;

public class Contact
{
    public int ContactId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int ContactTypeIdentifier { get; set; }
    public ContactType ContactType { get; set; } = new();
    public override string ToString() => $"{FirstName} {LastName}";
    
    public Contact(int id)
    {
        ContactId = id;
    }

    public Contact()
    {

    }

}