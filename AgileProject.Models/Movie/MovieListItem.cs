namespace AgileProject.Models.Movie
{
    public class MovieListItem
    {
        public int MovieId { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? Genre { get; set; }
        public string? ContentRating { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}