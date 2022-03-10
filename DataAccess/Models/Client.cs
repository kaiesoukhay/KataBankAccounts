using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class Client
    {

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Balance { get; set; }
        public int NumCompte { get; set; } 
        public IList<Operation> Operations { get; set; }
    }
}
