using CsvHelper;
using System.Globalization;
using System;
using Client;

using (var reader = new StreamReader("imdb_top_2000_movies.csv"))

using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
{
    csv.Context.RegisterClassMap<ModelClassMap>();
    var records = csv.GetRecords<Model>().ToList();
}


