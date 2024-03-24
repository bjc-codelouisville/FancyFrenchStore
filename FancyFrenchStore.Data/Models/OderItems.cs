using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFrenchStore.Data.Models
{
    internal class OderItems
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int ProductID { get; set; }
        public decimal Price { get; set; }
        public int OrderID { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedDate { get; set; }
    }
}
