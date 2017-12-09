using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ChoixResto.Models
{
    [Table("Restos")]
    public class Resto
    {
        public int Id { get; set; }
        //[Required]
        [Required(ErrorMessage = "Le nom du restaurant doit être saisi")]
        public string Nom { get; set; }
        public string Telephone { get; set; }
    }


}