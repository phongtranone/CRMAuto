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
    public class InsurancePoliciesPageObject:Elements
    {
        private static string xmlFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LocationElements\\InsurancePolicies.xml");
        public InsurancePoliciesPageObject() : base(xmlFilePath)
        {
        }

        public By NewButton => FindElementByKey("NewButton");
        public By InsuranceTextInput => FindElementByKey("InsuranceTextInput");
        public By DoneButton => FindElementByKey("DoneButton");
    }
}
