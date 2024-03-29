using System.ComponentModel.DataAnnotations;

namespace BlazorDirectoryProject;
public class Contact
{

    [Required]
    [Key]
    public int id { get; set; }
    [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "Please only enter letters in the name")]
    [Required]
    [MaxLength(15, ErrorMessage = "Name must be 15 characters or less")]
    public string nameContact { get; set; }
    [Phone(ErrorMessage = "Please only enter numbers in the landline")]
    [MaxLength(7, ErrorMessage = "Landline must be 7 digits"), MinLength(7, ErrorMessage = "Landline must be 7 digits ")]
    public string landlineContact { get; set; }
    [Phone(ErrorMessage = "Please only enter numbers in the cellphone")]
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