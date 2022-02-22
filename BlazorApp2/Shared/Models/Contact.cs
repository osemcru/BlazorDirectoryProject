using System.ComponentModel.DataAnnotations;

namespace BlazorDirectoryProject;
public class Contact
{

    [Required]
    [Key]
    public int id { get; set; }
    [Required(ErrorMessage = "Este campo es obligatorio")]
    [MaxLength(7, ErrorMessage = "Debe ingresar un número de telefono fijo 7 digitos. Gracias")]
    [MinLength(7, ErrorMessage = "Debe ingresar un número de telefono fijo 7 digitos. Gracias")]
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