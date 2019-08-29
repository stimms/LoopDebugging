using CsvHelper;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace LargeDataLoop
{
    class Program
    {
        static void Main(string[] args)
        {
using (var reader = new StreamReader(@"HBCDBiosolids_EN_FR.csv"))
using (var csv = new CsvReader(reader))
{
    var records = csv.GetRecords<Record>().ToList();
    var mean = records.Sum(x => x.CONCENTRATION_FOUND) / records.Count();
    var standardDeviation = Math.Sqrt(records.Sum(x => Math.Pow(x.CONCENTRATION_FOUND - mean, 2) / records.Count()));
    var cleanRecords = new List<Record>();
    foreach (var record in records)
    {
        var zScore = Convert.ToDouble(record.CONCENTRATION_FOUND - mean) / standardDeviation;
        if (Math.Abs(zScore) > 2)
            Console.WriteLine($"{record.CONCENTRATION_FOUND} - {zScore}");
        else
            cleanRecords.Add(record);
    }
}
        }
    }
}
