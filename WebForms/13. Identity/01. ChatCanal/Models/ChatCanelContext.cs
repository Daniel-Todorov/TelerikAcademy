using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System.Data.Entity;
using _01.ChatCanal.Migrations;

namespace _01.ChatCanal.Models
{
    public class ChatCanelContext : IdentityDbContext<ApplicationUser>
    {
        public ChatCanelContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ChatCanelContext, Configuration>());
        }

        public DbSet<Message> Messages { get; set; }

        public static ChatCanelContext Create()
        {
            return new ChatCanelContext();
        }
    }
}