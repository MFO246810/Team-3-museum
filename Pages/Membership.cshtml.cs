using Microsoft.AspNetCore.Mvc.RazorPages;
using Team_3_mueseum.Data;
using Team_3_mueseum.Model;

namespace Team_3_mueseum.Pages{
    public class MembershipModel : PageModel
    {
        private readonly AppDbContext _context;

        public MembershipModel(AppDbContext context)
        {
            _context = context;
        }

        public List<Membership> Memberships { get; set; }

        public void OnGet()
        {
            Memberships = _context.MembershipTable.ToList();
        }
    }
}
