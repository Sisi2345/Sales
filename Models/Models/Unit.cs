using Models.Base_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Unit : BaseEntity
    {
        public int UnitsSold { get; set; }

        public decimal UnitPrice { get; set; }
        public decimal UnitCost { get; set; }

        public Sales Sales { get; set; }
    }
}
