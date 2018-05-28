using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using OpenQA.Selenium;

namespace testSampleOne.TestCases
{
    class TestSuiteParser
    {
        public List<string> Nodes { get; set; }

        public TestSuiteParser(string path)
        {
            XDocument CommonsData = XDocument.Load(path);
            Nodes = new List<string>();
            foreach (var element in CommonsData.Root.Elements())
            {
                Nodes.Add(element.Value);
            }
        }
    }
}
