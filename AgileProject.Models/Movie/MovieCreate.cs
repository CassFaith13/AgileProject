using System.ComponentModel.DataAnnotations;

namespace AgileProject.Models.Movie
{
    public class MovieCreate
    {
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Genre { get; set; }
        [Required]
        public string? ContentRating { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
    }
}