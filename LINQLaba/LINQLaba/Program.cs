using System.Linq;
using System.Collections.Generic;

namespace LINQLaba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AllReports allReports = new AllReports();
            RegionList regions = new RegionList();
            regions.addRegion(new Region("Kyiv", "Capital city"));
            regions.addRegion(new Region("Lutsk", "Volyn region"));
            regions.addRegion(new Region("Lviv", "Lviv region"));

            for (int i = 1; i <= 31; i++)
            {
                allReports.Add(new Report(i, new DateOnly(2023, 03, i), "Clear", regions.getRegionByName("Kyiv")));
            }
            allReports.changeRepotrByDate(DateOnly.FromDateTime(DateTime.Now), "Snow");

            allReports.changeRepotrById(12, "Snow");

            allReports.changeRepotrById(15, "Snow");

            allReports.changeRegionByReportId(20, regions.getRegionByName("Kyiv"), regions.getRegionByName("Lutsk"));

            allReports.printReports();
        }
    }
}