using System.ComponentModel.DataAnnotations;

namespace AgileProject.Data.Entities
{
    public class RatingEntity
    {
        [Key]
        public int RatingId { get; set; }
        public int MovieId { get; set; }
        public MovieEntity Movies { get; set; }
        public int ShowId { get; set; }
        public ShowEntity Shows { get; set; }
    }
}