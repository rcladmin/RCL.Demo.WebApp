namespace RCL.Demo.WebApp
{
    public interface IBookingService
    {
        Task<List<Models.Booking>> GetUserBookings(string userId);
    }
}
