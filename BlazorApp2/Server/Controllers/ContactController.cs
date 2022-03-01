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

    [HttpDelete("{name}")]
    public IActionResult DeleteContact(string name)
    {
        var cont = _context.Contacts.SingleOrDefault(x => x.nameContact == name);
        if (cont == null)
        {
            return NotFound("The contact with the name " + name + " does not exist in the directory");
        }
        _context.Contacts.Remove(cont);
        _context.SaveChanges();
        return Ok("The contact with the name " + name + " has been deleted");
    }

    [HttpGet("{name}")]
    public Contact FindOneContact(string name)
    {
        try
        {
            var cont = _context.Contacts.SingleOrDefault(x => x.nameContact == name);
            return cont;
        }
        catch (Exception)
        {
            throw;
        }
    ;
    }

    [HttpGet("thereIs/{name}")]
    public bool GetOneContact(string name)
    {
        try
        {
            var cont = _context.Contacts.SingleOrDefault(x => x.nameContact == name);
            if (cont != null)
            {
                return true;
            }
        }
        catch (Exception)
        {
        }
        return false;
    }
}




