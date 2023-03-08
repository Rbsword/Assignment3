using System.ComponentModel.DataAnnotations;

namespace Assignment_3_Riva_Sword.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Genre { get; set; }
        [Url]
        public string? IMDBHyperlink { get; set; }
        public int ReleaseYear { get; set; }
        public byte[] MoviePoster { get; set; }

        

    }
}
