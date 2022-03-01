using System.ComponentModel.DataAnnotations;

namespace BlazorDirectoryProject;
public class Contact
{

    [Required]
    [Key]
    public int id { get; set; }
    [RegularExpression(@"^[a-zA-Z ]+$")]
    [Required]
    [MaxLength(15, ErrorMessage = "Name must be 15 characters or less")]
    public string nameContact { get; set; }
    [Phone]
    [MaxLength(7, ErrorMessage = "Landline must be 7 digits"), MinLength(7, ErrorMessage = "Landline must be 7 digits ")]
    public string landlineContact { get; set; }
    [Phone]
    [MaxLength(13, ErrorMessage = "The cellphone must have between 10 to 13 digits"), MinLength(10, ErrorMessage = "The cellphone must have between 10 to 13 digits")]
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