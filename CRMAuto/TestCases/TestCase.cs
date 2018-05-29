using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testSampleOne.TestCases
{
    public interface TestCase
    {
        void RunTest();
        string GetName();
        void DisplayID(string id);
    }
}
