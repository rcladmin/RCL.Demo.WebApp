using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RCL.Demo.WebApp.Pages.Payment
{
    [AllowAnonymous]
    public class SuccessModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
