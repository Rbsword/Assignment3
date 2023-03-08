using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_3_Riva_Sword.Models
{
    public class MovieActor
    {
        public int Id { get; set; }

        [ForeignKey("Movies")]
        public int? MovieId { get; set; }
        public Movie? Movie { get; set;}
     
        [ForeignKey("Actors")]
        public int? ActorId { get; set; }
        public Actor? Actor { get; set; }

    }
}
