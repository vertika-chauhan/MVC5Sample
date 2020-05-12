using MVC5.Models;
using System.Collections.Generic;

namespace MVC5.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}