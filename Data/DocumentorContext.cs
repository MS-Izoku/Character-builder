using Microsoft.EntityFrameworkCore;
using testMVC.Models;

namespace testMVC.Data
{
    public class DocumentorContext : DbContext
    {
        public DocumentorContext (DbContextOptions<DocumentorContext> options) : base(options){}

        public DbSet<Document> Document { get; set; }
    }
}