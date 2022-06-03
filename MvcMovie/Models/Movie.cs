using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {

        public int Id { get; set; }
        public string? Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; } = DateTime.Now;

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Display(Name = "Genres")]
        virtual public ICollection<GenreMovie> genreMovie { get; set; } = new List<GenreMovie>();
    }
}
