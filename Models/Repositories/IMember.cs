using MemberDemo.Models.Classes;
using System.Collections.Generic;

namespace MemberDemo.Models.Repositories
{
    public interface IMember
    {
        public Member Add(Member member);
        public Member Edit(Member member);
        public Member Delete(int ID);
        public Member Get(int ID);
        public IEnumerable<Member> GetAll();
    }
}
