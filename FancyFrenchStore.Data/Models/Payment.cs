using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFrenchStore.Data.Models
{
    public class Payment
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int OrderID { get; set; }
        public int PaymentTypeID { get; set; }
        public string PaymentAccount { get; set; }
        public int PaymentAddressID { get; set; }
        public decimal PaymentAmount { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedDate { get; set; }
    }
}
