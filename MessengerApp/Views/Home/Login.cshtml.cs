using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace MessengerApp.Views.Home
{

    public class LoginModel : PageModel

    {
        private readonly SignInManager<IdentityUser> signInManager;

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool rememberMe = true;
        public LoginModel(SignInManager<IdentityUser> signInManager)
        {

        }
        public void OnGet()
        { }
        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            if (ModelState.IsValid)
            {

                var result = await signInManager.PasswordSignInAsync(Email, Password, rememberMe, true);

                if (result.Succeeded)
                {
                    return RedirectToAction("Dashboard");
                }
                else if (result.IsLockedOut)
                {
                    return Page();
                }
                else
                {
                    ModelState.AddModelError("message", "Invalid login attempt");
                    return Page();
                }
            }
            return Page();
        }

    }
}


              
          


    

