using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RCL.Core.Identity.Tools;

namespace RCL.Demo.WebApp.Pages
{
    [AllowAnonymous]
    public class IndexModel : PageModel
    {
        public string UserId { get; set; } = string.Empty;

        public IndexModel()
        {
        }

        public void OnGet()
        {
            if(!string.IsNullOrEmpty(User?.Identity?.Name))
            {
                UserId = UserClaimsHelper.GetUserDataFromClaims(User).ObjectId;
            }
        }
    }
}