using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Prueba.Models
{
    public class Singer
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        //list of albums that the singer has

        //public List<Album> Albums { get; set; }




    }
}