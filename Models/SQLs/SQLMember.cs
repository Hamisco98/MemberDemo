using MemberDemo.Models.Classes;
using MemberDemo.Models.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MemberDemo.Models.SQLs
{
    public class SQLMember : IMember
    {
        private readonly LogDemoDbContext context;

        public SQLMember(LogDemoDbContext context)
        {
            this.context = context;
        }
        public Member Add(Member member)
        {
            context.Members.Add(member);
            context.SaveChanges();
            return member;
        }

        public Member Delete(int ID)
        {
            Member member = context.Members.Find(ID);
            if (member != null)
            {
                context.Members.Remove(member);
                context.SaveChanges();
            }
            return member;
        }

        public Member Edit(Member member)
        {
            var editMember = context.Members.Attach(member);
            editMember.State = EntityState.Modified;
            context.SaveChanges();
            return member;
        }

        public Member Get(int ID)
        {
            return context.Members.Find(ID);
        }

        public IEnumerable<Member> GetAll()
        {
            return context.Members;
        }
    }
}
