﻿//11. Create a database holding users and groups. Create 
//a transactional EF based method that creates an 
//user and puts it in a group "Admins". In case the 
//group "Admins" do not exist, create the group in the 
//same transaction. If some of the operations fail (e.g. 
//the username already exist), cancel the entire 
//transaction.


namespace UsersAndGroups
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class UsersDB
    {
        static void Main(string[] args)
        {
            using (var db = new UsersContext())
            {
                DeleteGroupsAndUsers(db);

                AddUser(db, "Superman");

                var query = from us in db.Users
                            select us;

                foreach (var item in query)
                {
                    Console.WriteLine("Name: {0}, Group: {1}", item.UserName, item.GroupId);
                }
                foreach (var group in db.Groups)
                {
                    Console.WriteLine("GroupId:{0}, GroupName: {1}", group.GroupId, group.GroupName);
                }
            }
        }

        private static void AddUser(UsersContext db, string name)
        {
            var gods = db.Groups.Where(x => x.GroupName == "Gods").ToList();

            if (gods.Count == 0)
            {
                db.Groups.Add(new Group()
                {
                    GroupName = "Gods"
                });
                db.SaveChanges();
                gods = db.Groups.Where(x => x.GroupName == "Gods").ToList();
            }

            User user = new User()
            {
                UserName = name,
                GroupId = gods[0].GroupId
            };

            db.Users.Add(user);
            db.SaveChanges();
        }

        private static void DeleteGroupsAndUsers(UsersContext db)
        {
            var toDelete = from us in db.Users
                           select us;
            foreach (var item in toDelete)
            {
                db.Users.Remove(item);
            }

            var groupsToDelete = from gr in db.Groups
                                 select gr;
            foreach (var item in groupsToDelete)
            {
                db.Groups.Remove(item);
            }

            db.SaveChanges();
        }
    }


    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
    }

    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int GroupId { get; set; }
    }

    public class UsersContext : DbContext
    {
        public virtual DbSet<Group> Groups { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
