using System.ComponentModel.DataAnnotations;

namespace AgileProject.Data.Entities
{
    public class ShowEntity
    {
        [Key]
        public int ShowId { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Genre { get; set; }
        [Required]
        public string? ContentRating { get; set; }
        [Required]
        public int NumberOfSeasons { get; set; }
        [Required]
        public DateTime ReleaseYear { get; set; }
    }
}