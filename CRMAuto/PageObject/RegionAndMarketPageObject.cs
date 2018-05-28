using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using testSampleOne.Parser.LocationElements;

namespace testSampleOne.PageObject
{
    public class RegionAndMarketPageObject : Elements
    {
        private static string xmlFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LocationElements\\RegionAndMarkets.xml");
        public RegionAndMarketPageObject() : base(xmlFilePath)
        {
            
        }

        public By NewBtn => FindElementByKey("NewButton");
        public By RegionItem => FindElementByKey("RegionItem");
        public By RegionName => FindElementByKey("RegionName");
        public By RegionDescription => FindElementByKey("RegionDescription");
        public By DoneButtonRegion => FindElementByKey("DoneButtonRegion");

        public By MarketItem => FindElementByKey("MarketItem");
        public By MarketName => FindElementByKey("MarketName");
        public By MarketDescription => FindElementByKey("MarketDescription");
        public By DoneButtonMarket => FindElementByKey("DoneButtonMarket");
    }
}
