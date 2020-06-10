using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtudiantService.Models.Entities
{
    public class Etudiant
    {
        public int Id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string Nom_filiere { get; set; }
    }
}
