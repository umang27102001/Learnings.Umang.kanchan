using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPractice.OCP.ReportGenerationSystem
{
    internal class JSONReportGenerator : IReportGenerator
    {
        public void GenerateReport(string data)
        {
            Console.WriteLine($"JSON Report generated {data}");
        }
    }
}
