using DocumentsService.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace DocumentsService.Data
{
    public class DocumentContext : DbContext
    {
        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<DocumentPermission> DocumentPermissions { get; set; }
        public DbSet<DocumentHistory> DocumentHistories { get; set; }

        public DocumentContext(DbContextOptions<DocumentContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configure relationships
        }
    }

}
