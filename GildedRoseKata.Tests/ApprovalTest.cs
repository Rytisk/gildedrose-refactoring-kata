using Xunit;
using System;
using System.IO;
using System.Text;
using ApprovalTests;
using ApprovalTests.Reporters;
using GildedRoseKata.App;

namespace GildedRoseKata.Tests
{
    [UseReporter(typeof(DiffReporter))]
    public class ApprovalTest
    {
        [Fact (Skip = "I would remove this. But maybe you will use it?")]
        public void ThirtyDays()
        {
            var fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            Console.SetIn(new StringReader("a\n"));

            Program.Main(new string[] { });
            var output = fakeoutput.ToString();

            Approvals.Verify(output);
        }
    }
}
