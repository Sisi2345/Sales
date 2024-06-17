using Models.Base_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class SalesOrder : BaseEntity
    {
        public class Order
        {
            public int OrderId { get; set; }
            public Sales Sales { get; set; }
        }

        public class Sales
        {
            public int SalesId { get; set; }
            public int OrderId { get; set; }
            public Order Order { get; set; }
            public Total Total { get; set; }
        }

        public class Total
        {
            public int TotalId { get; set; }
            public int SalesId { get; set; }
            public Sales Sales { get; set; }
        }



    }
}
