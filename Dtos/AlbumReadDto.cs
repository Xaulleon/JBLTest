using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Prueba.Models;

namespace Prueba.Dtos
{
    public class AlbumReadDto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Rating { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public double Price { get; set; }

        public string Review { get; set; }




        //The Singer that the album belongs to
        [Required]
        public int SingerId { get; set; }

        [Required]
        public Singer Singer { get; set; }

        //The Songs that belong to the album

        public List<Song> Songs { get; set; }

    }
}