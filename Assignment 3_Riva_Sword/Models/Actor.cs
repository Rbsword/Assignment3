using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_3_Riva_Sword.Models
{
    public class Actor
    {
       
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public int age { get; set; }
        [Url]
        public string? IMBDLink { get; set; }
        public byte[] ActorPhoto { get; set; }
        [ForeignKey("Movies")]
        public string? MovieId { get; set; }
        public Movie? Movie { get; set; }

    }
}
