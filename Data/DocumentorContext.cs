using Microsoft.EntityFrameworkCore;
using testMVC.Models;

// Creates Database Context for persisting information
namespace testMVC.Data
{
    public class DocumentorContext : DbContext
    {
        // the App Context
        public DocumentorContext (DbContextOptions<DocumentorContext> options) : base(options){}

        // DB tables w/ models
        public DbSet<Document> Document { get; set; }
        
    }
}