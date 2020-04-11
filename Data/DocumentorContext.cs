using Microsoft.EntityFrameworkCore;
using testMVC.Models;

// Creates Database Context for persisting information
namespace testMVC.Data {
    public class DocumentorContext : DbContext {
        // the App Context
        public DocumentorContext (DbContextOptions<DocumentorContext> options) : base (options) { }

        // DB tables w/ models
        public DbSet<Book> Book { get; set; }
        public DbSet<Chapter> Chapter { get; set; }
        public DbSet<Character> Character { get; set; }
        public DbSet<Document> Document { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<TextArea> TextArea { get; set; }
    }
}