using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RCL.Demo.WebApp.Pages.Payment
{
    [AllowAnonymous]
    public class CancelModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
