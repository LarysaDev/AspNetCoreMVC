using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using MessengerApp.Models;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Identity;

namespace MessengerApp.Data
{
    public class ApplicationDBContext: IdentityDbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
           : base(options) { }
        /*
                protected override void OnModelCreating(ModelBuilder builder)
                {
                    base.OnModelCreating(builder);
                    builder.Entity<Message>()
                        .HasOne<User>(a => a.Sender)
                        .WithMany(d => d.Messages)
                        .HasForeignKey(d => d.UserID);
                }
        */
    }
}
