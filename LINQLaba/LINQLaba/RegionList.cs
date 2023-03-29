using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLaba
{
    public class RegionList
    {
        List<Region> regions;
        public RegionList()
        {
            regions = new List<Region>();
        }
        public void addRegion(Region region)
        {
            regions.Add(region);
        }
        public void removeRegion(Region region)
        {
            regions.Remove(region);
        }
        public Region getRegionByName(string name)
        {

            IEnumerable<Region> Regions = from data in regions
                                                  where data.Name == name
                                                  select data;

            return Regions.First();
        }
    }
}
