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

        public async Task AddUser(user U)
        {
            _context.UserTable.Add(U);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteUserAsync(string username){
            var user = await _context.UserTable.FindAsync(username); // Find user by ID
                if (user == null)
                    {
                        return false; // User not found
                    }

             _context.UserTable.Remove(user); // Remove user
            await _context.SaveChangesAsync(); // Commit changes to the database

            return true;
        }
    }
}
