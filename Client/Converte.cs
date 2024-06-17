using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{

    using (var reader = new StreamReader("2m Sales Records.csv"))

using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
{
    csv.Context.RegisterClassMap<ModelClassMap>();
    var records = csv.GetRecords<Model>().ToList();
}

}

