
using MVC5.Models;
using MVC5.ViewModels;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;




namespace MVC5.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;


        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        public ViewResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();


            //var customers =
            //    _context.Movies.Include(g=>g.Genre).ToList();

            return View(movies);
        }


        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
        }



        public ActionResult Details(int id)
        {
            var Movies = _context.Movies.Include(c => c.Genre).SingleOrDefault(c => c.Id == id);

            if (Movies == null)
                return HttpNotFound();

            return View(Movies);
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }
    }
}