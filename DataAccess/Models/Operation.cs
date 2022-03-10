using System;

namespace DataAccess.Models
{
    public  class Operation
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public int Montant { get; set; }
        public DateTime Date { get; set; }
        public Client Clients { get; set; }
    }
}
