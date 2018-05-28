using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testSampleOne.TestCases
{
    public class TestRunner
    {
        private TestCase _testCase;
        public TestRunner(TestCase testCase)
        {
            _testCase = testCase;
        }

        public void Run()
        {
            _testCase.RunTest();
        }
    }
}
