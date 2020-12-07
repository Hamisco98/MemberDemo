using MemberDemo.Models.Classes;
using System.Collections.Generic;

namespace MemberDemo.Models.Repositories
{
    public interface IAdmin
    {
        public Admin Add(Admin admin);
        public Admin Edit(Admin admin);
        public Admin Delete(int ID);
        public Admin Get(int ID);
        public IEnumerable<Admin> GetAll();
    }
}
