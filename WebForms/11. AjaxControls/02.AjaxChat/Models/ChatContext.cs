using _02.AjaxChat.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _02.AjaxChat.Models
{
    public class ChatContext : DbContext
    {
        public ChatContext()
            : base("AjaxChatDb")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ChatContext, Configuration>());
        }

        public DbSet<Message> Messages { get; set; }
    }
}