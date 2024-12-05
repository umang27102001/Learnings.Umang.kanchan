using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPractice.OCP.ReportGenerationSystem
{
    internal class PdfReportGenerator : IReportGenerator
    {
        public void GenerateReport(string data)
        {
            Console.WriteLine($"PDF Report generated {data}");
        }
    }
}
