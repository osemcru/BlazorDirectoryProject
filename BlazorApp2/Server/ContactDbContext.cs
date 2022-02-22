
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDirectoryProject;

public class ContactDbContext : DbContext
{

    public ContactDbContext(DbContextOptions<ContactDbContext> options) : base(options)
    {
    }
    public DbSet<Contact> Contacts { get; set; }

}