using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Einkaufsliste.Models
{
    public class Position
    {
        [Required(ErrorMessage = "please enter the name of the article")]
        public string Name { get; set; }
        [Required(ErrorMessage = "please enter the number of products")]
        public int Anzahl { get; set; }
        [Required(ErrorMessage = "please enter the name of the store")]
        public string Geschäft { get; set; }

    }    

}
