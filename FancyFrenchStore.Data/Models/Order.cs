using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFrenchStore
{
    public class Order
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid? CustomerID { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
    }
}
