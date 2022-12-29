using System.ComponentModel.DataAnnotations;

namespace AgileProject.Data.Entities
{
    public class MovieEntity
    {
        [Key]
        public int MovieId { get; set; }
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