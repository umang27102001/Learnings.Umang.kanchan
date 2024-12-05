using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPractice.OCP.ReportGenerationSystem
{
    internal class CsvReportGenerator : IReportGenerator
    {
        public void GenerateReport(string data)
        {
            Console.WriteLine($"CSV Report generated {data}");
        }
    }
}
