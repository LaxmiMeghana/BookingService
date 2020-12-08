using BookingService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingService.Repository
{
    public class BookingRepository : IBookingRepository
    {
        List<Booking> Booklist = new List<Booking>();
        public BookingRepository()
        {
            Booklist.Add(new Booking { Booking_Id = 1, User_Id = 1, Item_Id = 1, Item_Name = "Sandwich", Cost = 100, Category = "Main Course" });
            Booklist.Add(new Booking { Booking_Id = 2, User_Id = 2, Item_Id = 2, Item_Name = "French Fries", Cost = 57, Category = "Staters" });
            
        }
        //private readonly BookingDbContext dbContext;
        /* public BookingRepository(BookingDbContext _dbContext)
         {
             this.dbContext = _dbContext;
         }*/
        //public Booking book(Booking model)
        /*{
            var result = dbContext.Bookings.Add(model);
            dbContext.SaveChanges();
            return model;
        }*/


        public List<Booking> book(Booking model)
        {
            Booklist.Add(model);
            return Booklist;
        }

        public IEnumerable<Booking> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Booking> GetById(int user_id)
        {
            List<Booking> blist = new List<Booking>();
            foreach (var b in Booklist)
            {
                if (b.User_Id == user_id)
                {
                    blist.Add(b);
                }
            }
            return blist;
        }

        Booking IBookingRepository.book(Booking entity)
        {
            throw new NotImplementedException();
        }
    }
}
