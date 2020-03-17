using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Superhero_App.Models
{
    public class Superhero
    {  [Key]
        public int SuperheroID { get; set; }
        public string HeroName { get; set; }
        public string AlterFirstName { get; set; }
        public string AlterLastName { get; set; }
        public string PrimaryAbility { get; set; }
        public string SecondaryAbility { get; set; }
        public string CatchPhrase { get; set; }
    }
}
