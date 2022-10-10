using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RCL.Core.Identity.Tools;

namespace RCL.Demo.WebApp.Pages.Booking
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly IBookingService _bookingService;

        public List<Models.Booking> Bookings = new List<Models.Booking>();
        public UserClaimsData UserClaimsData { get; set; } = new UserClaimsData();

        public IndexModel(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        public async Task OnGet()
        {
            UserClaimsData = UserClaimsHelper.GetUserDataFromClaims(User);

            Bookings = await _bookingService
                .GetUserBookings(UserClaimsData.ObjectId);
        }
    }
}
