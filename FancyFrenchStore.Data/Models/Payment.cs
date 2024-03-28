using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFrenchStore
{
    public class Payment
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid? OrderID { get; set; }
        public Guid? PaymentTypeID { get; set; }
        public string? PaymentAccount { get; set; }
        public Guid? PaymentAddressID { get; set; }
        public decimal? PaymentAmount { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
    }
}
