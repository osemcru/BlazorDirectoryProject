using System.ComponentModel.DataAnnotations;

namespace BlazorDirectoryProject;
public class Contact
{

    [Required]
    [Key]
    public int id { get; set; }
    public string nameContact { get; set; }
    public string landlineContact { get; set; }
    public string cellphoneContact { get; set; }
    public Contact(string nameContact, string landlineContact, string cellphoneContact)
    {
        this.nameContact = nameContact;
        this.landlineContact = landlineContact;
        this.cellphoneContact = cellphoneContact;
    }
    public Contact(string nameContact)
    {
        this.nameContact = nameContact;
    }
    public Contact()
    {
    }
}