using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLaba
{
    public class AllReports
    {
        List<Report> allReports;
        public AllReports()
        {
            allReports = new List<Report>();
        }
        public void Add(Report report) { 
            allReports.Add(report);
        }
        public void Remove(Report report)
        {
            allReports.Remove(report);
        }
        public void changeRegionByReportId(int idToSearch, Region regionToSearch, Region newRegion)
        {

            IEnumerable<Report> reportsForDates = from data in allReports
                                                  where data.Uid == idToSearch &&
                                                  data.Region == regionToSearch
                                                  select data;
            foreach (Report report in reportsForDates)
            {
                report.changeRegion(newRegion);
            }
        }
        public void changeRepotrById(int idToSearch, string newReport)
        {

            IEnumerable<Report> reportsForDates = from data in allReports
                                                  where data.Uid == idToSearch
                                                  select data;
            foreach (Report report in reportsForDates)
            {
                report.changeReport(newReport);
            }
        }
        public void changeRepotrByDate(DateOnly dateToSearch, string newReport)
        {

            IEnumerable<Report> reportsForDates = from data in allReports
                                                  where data.Date == dateToSearch
                                                  select data;
            foreach (Report report in reportsForDates)
            {
                report.changeReport(newReport);
            }
        }
        public void printReports()
        {
            foreach (var item in allReports)
            {
                Console.WriteLine(item.Uid + " | " + item.Date + " | " + item.Region + " | " + item.WeatherReport);
            }
        }
    }
}
