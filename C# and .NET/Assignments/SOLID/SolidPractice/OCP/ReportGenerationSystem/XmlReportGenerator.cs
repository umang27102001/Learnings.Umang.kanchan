using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPractice.OCP.ReportGenerationSystem
{
    internal class XmlReportGeneratorL : IReportGenerator
    {
        public void GenerateReport(string data)
        {
            Console.WriteLine($"XML Report generated {data}");
        }
    }
}
