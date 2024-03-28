using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace FancyFrenchStore
    { 
    public class Address
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid? CustomerID { get; set; } 
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? City { get; set; }
        public string? State {  get; set; }
        public string? PostalCode { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
    }
}
