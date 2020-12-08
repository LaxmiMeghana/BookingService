using BookingService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingService.Repository
{
    public interface IBookingRepository
    {
        public IEnumerable<Booking> GetById(int Bookingid);

        Booking book(Booking entity);
        IEnumerable<Booking> GetAll();
    }
}