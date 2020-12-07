using MemberDemo.Models.Classes;
using MemberDemo.Models.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MemberDemo.Models.SQLs
{
    public class SQLAdmin : IAdmin
    {
        private readonly LogDemoDbContext context;

        public SQLAdmin(LogDemoDbContext context)
        {
            this.context = context;
        }
        public Admin Add(Admin admin)
        {
            context.Admins.Add(admin);
            context.SaveChanges();
            return admin;
        }

        public Admin Delete(int ID)
        {
            Admin admin = context.Admins.Find(ID);
            if (admin != null)
            {
                context.Admins.Remove(admin);
                context.SaveChanges();
            }
            return admin;
        }

        public Admin Edit(Admin admin)
        {
            var editAdmin = context.Admins.Attach(admin);
            editAdmin.State = EntityState.Modified;
            context.SaveChanges();
            return admin;
        }

        public Admin Get(int ID)
        {
            return context.Admins.Find(ID);
        }

        public IEnumerable<Admin> GetAll()
        {
            return context.Admins;
        }
    }
}
