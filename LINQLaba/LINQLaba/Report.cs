using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLaba
{
    public class Report
    {
        public int Uid { get; set; }
        public DateOnly Date { get; set; }
        public string WeatherReport { get; set; }
        public Region Region { get; set; }

        public Report(int id, DateOnly date, string report, Region region) { 
            Uid = id;
            Date = date;
            WeatherReport = report;
            Region = region;
        }
        public void changeReport(string NewReport)
        {
                WeatherReport = NewReport;
        }
        public void changeRegion(Region NewRegion)
        {
            Region = NewRegion;
        }
    }
}
