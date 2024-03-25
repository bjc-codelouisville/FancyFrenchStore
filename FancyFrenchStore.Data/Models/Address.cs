using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFrenchStore.Data
{ 
    public class Address
    {
    public Guid Id { get; set; } = Guid.NewGuid();
    public int CustomerID { get; set; } 
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
    public string City { get; set; }
    public string State {  get; set; }
    public string PostalCode { get; set; }
    public string CreatedDate { get; set; }
    public string UpdatedDate { get;set; }
    }
}
