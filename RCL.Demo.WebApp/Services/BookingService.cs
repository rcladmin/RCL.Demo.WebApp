using Microsoft.Extensions.Options;
using RCL.Core.Api.RequestService;
using RCL.Core.Authorization;

namespace RCL.Demo.WebApp.Services
{
    public class BookingService : ApiRequestBase, IBookingService
    {
        private readonly IOptions<ApiOptions> _options;

        public BookingService(IAuthTokenService authTokenService, IOptions<ApiOptions> options) : base(authTokenService)
        {
            _options = options;
        }

        public async Task<List<Models.Booking>> GetUserBookings(string userId)
        {
            string uri = $"{_options.Value.BaseUri}/v1/demo/booking/userid/{userId}/getall";

            List<Models.Booking> bookings = await GetListResultAsync<Models.Booking>(uri, _options.Value.Resource);

            return bookings;
        }
    }
}
