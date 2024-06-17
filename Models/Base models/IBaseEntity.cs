using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Base_models
{
    public interface IBaseEntity
    {
        public string Id { get; set; }

    }
}

