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
    public class HomePageObject : Elements
    {
        private static string xmlFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LocationElements\\HomePage.xml");
        public HomePageObject() : base(xmlFilePath)
        {

        }

        public By HamburgerMenuIcon => FindElementByKey("HamburgerMenu");
        public By RegionAndMarketsMenu => FindElementByKey("RegionAndMarkets");
        public By NameOfUser => FindElementByKey("NameOfUser");
        public By InsurancePoliciesMenu => FindElementByKey("InsurancePoliciesMenu");
    }
}
