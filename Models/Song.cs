using System.ComponentModel.DataAnnotations;

namespace Prueba.Models
{
    public class Song
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }

        public int Popularity { get; set; }

        public double Price { get; set; }

        [Required]
        public int AlbumId { get; set; }

        // [Required]
        // public Album Album { get; set; }

    }
}