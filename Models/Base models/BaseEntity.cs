using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Base_models
{
    public class BaseEntity : IBaseEntity
    {
        public string Id { get; set; }

        public BaseEntity() 
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
