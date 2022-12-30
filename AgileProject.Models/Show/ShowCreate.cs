namespace AgileProject.Models.Show
{
    public class ShowCreate
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