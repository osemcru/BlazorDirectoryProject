using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlazorDirectoryProject;


[Route("api/[controller]")]
[ApiController]
public class ContactController : ControllerBase
{
    private readonly ContactDbContext _context;
    public ContactController(ContactDbContext context)
    {
        _context = context;
    }
    // GET: api/Contact
    [HttpGet]
    public IEnumerable<Contact> GetAllContacts()
    {
        try
        {
            return _context.Contacts.ToList();
        }
        catch (Exception e)
        {
            throw;
        }
    }

    [HttpPost]
    public IActionResult AddContact(Contact contact)
    {
        _context.Contacts.Add(contact);
        _context.SaveChanges();
        return Ok(_context.Contacts.ToList());
    }
}

