using Models.Base_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Region : BaseEntity
    {
        public string RegionName { get; set; }

        public string CountryName { get; set; }

        public List<Sales> Sales { get; set; }
    }
}
