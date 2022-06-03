namespace MvcMovie.Models
{
    public class GenreMovie
    {
        //Uses Composite keys

        public ulong genreId { get; set; }
        public Genre genre { get; set; }

        public int movieId { get; set; }
        public Movie movie { get; set; }


    }
}
