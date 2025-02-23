using System.Collections.Generic;
using System.Linq;
using Team_3_mueseum.Data;
using Team_3_mueseum.Model;
using Microsoft.EntityFrameworkCore;

namespace Team_3_mueseum
{
    public class UserService
    {
        private readonly AppDbContext _context;

        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public List<user> GetUser()
        {
            return _context.UserTable.ToList(); // Fetches all products
        }

        public void AddUser(user U)
        {
            _context.UserTable.Add(U);
            await _context.SaveChanges();
        }
    }
}
