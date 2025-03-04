using Microsoft.AspNetCore.Mvc;
using Team_3_mueseum;
using Team_3_mueseum.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Team_3_mueseum.Pages
{
    public class IndexModel : PageModel
    {
        private readonly UserService _userService;

        [BindProperty] 
        public user NewUser { get; set; } = new(); // Model Binding for form data

        public IndexModel(UserService userService)
        {
           _userService = userService;
        }
        private readonly ILogger<IndexModel> _logger;

        public void OnGet(){}
        public async Task<IActionResult> OnPostAddUserAsync(){
            if (!ModelState.IsValid){
                return Page(); }

            await _userService.AddUser(NewUser);
            return Page();
        }

        public async Task<IActionResult> OnPostDeleteUserAsync(string username){

            await _userService.DeleteUserAsync(username);
            return Page();
        }


    }
}
