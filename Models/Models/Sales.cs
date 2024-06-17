using Models.Base_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Sales : BaseEntity
    {
        public List<Region> Regions { get; set; }
        public string Item { get; set; }

        public string Type { get; set; }
        public string SalesChannel { get; set; }
        public Order Order { get; set; }
        public Unit Unit { get; set; }

        public Total Total { get; set; }
    }
}
