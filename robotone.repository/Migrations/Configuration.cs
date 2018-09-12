namespace RobotOne.Repository.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using RobotOne.Domain;

    internal sealed class Configuration : DbMigrationsConfiguration<RobotOne.DAL.RobotContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RobotOne.DAL.RobotContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            //Add initial data for Group table
            context.Groups.AddOrUpdate(c => c.Name,
                new Group { Id = 1, Name = "COM", ParentId = 0 },
                new Group { Id = 2, Name = "HR", ParentId = 1 },
                new Group { Id = 3, Name = "Microsoft", ParentId = 1 },
                new Group { Id = 4, Name = "ADT", ParentId = 1 },
                new Group { Id = 5, Name = "Salesforce", ParentId = 1 }
            );
            //add intital data for User table
            context.Users.AddOrUpdate(c => c.Name,
                new User { Id = 1, GroupId = 1, Name = "Hong" ,Email="hong.zheng@pwc.com",Role="Admin"},
                new User { Id = 2, GroupId = 2, Name = "Luis" , Email = "luis.q.lu@pwc.com", Role = "Admin" },
                new User { Id = 3, GroupId = 3, Name = "Jamine", Email = "jamine.li@pwc.com", Role = "Admin" },
                new User { Id = 4, GroupId = 3, Name = "Aoyang", Email = "ao.yang@pwc.com", Role = "Admin" },
                new User { Id = 5, GroupId = 3, Name = "Vivi" , Email = "vivi.lei@pwc.com", Role = "Admin" }
           );
            //Add initial data for Bot Table
           context.Bots.AddOrUpdate(c => c.Name,
               new Bot { Id = 1, GroupId = 1, Phase="Development", UserId = 1, Name = "Hong-Bot" },
               new Bot { Id = 2, GroupId = 3, Phase = "Stage", UserId = 3, Name = "Jamine-Bot" },
               new Bot { Id = 3, GroupId = 3, Phase = "Stage", UserId = 4, Name = "Aoyang-Bot" },
               new Bot { Id = 4, GroupId = 3, Phase = "Development", UserId = 5, Name = "Vivi-Bot" },
               new Bot { Id = 5, GroupId = 2, Phase = "Released", UserId = 2, Name = "Luis-Bot" }
         );
        }
    }
}
