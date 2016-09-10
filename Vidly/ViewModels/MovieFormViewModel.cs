using System.Collections.Generic;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public Movie Movie { get; set; }
        public List<Genre> Genres { get; set; }
    }
}