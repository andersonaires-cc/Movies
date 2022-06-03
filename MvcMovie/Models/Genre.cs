using Microsoft.EntityFrameworkCore;

namespace MvcMovie.Models
{
    public class Genre
    {
        public ulong Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        virtual public ICollection<GenreMovie> genreMovies { get; set; } = new List<GenreMovie>();

        public override string ToString()
        {
            return Name;
        }
    }
}
