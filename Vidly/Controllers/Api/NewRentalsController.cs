using MVC5.Dtos;
using MVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Vidly.Controllers.Api
{
    public class NewRentalsController : ApiController
    {

        private ApplicationDbContext _context;
        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {

            var customer = _context.Customers.Single(
                c => c.Id == newRental.CustomerId
                );

            //select * from movies where id in(1,2,3)
            var movies = _context.Movies.Where(
                m => newRental.MovieIds.Contains(m.Id)
                );

            foreach (var movie in movies)
            {

                if (movie.NumberAvailable == 0)
                {
                    return BadRequest("Movie is not avaliable");
                }
                movie.NumberAvailable--;
                var rental = new Rental
                {
                    customer = customer,
                    movie = movie,
                    DateRented = DateTime.Now
                };
                _context.rentals.Add(rental);

            }

            _context.SaveChanges();

            return Ok();
        }
    }
}
