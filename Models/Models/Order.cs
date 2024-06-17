using Models.Base_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Order : BaseEntity
    {
        public string OrderPriority { get; set; }
        public DateTime OrderDate { get; set; }

        public DateTime ShipDate { get; set; }

        public Sales Sales { get; set; }
    }
}

