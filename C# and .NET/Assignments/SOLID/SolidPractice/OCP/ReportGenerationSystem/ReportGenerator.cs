using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPractice.OCP.ReportGenerationSystem
{
    internal class ReportGenerator
    {
        private readonly IReportGenerator _generator;
        public ReportGenerator(IReportGenerator generator) { _generator = generator; }
        public void GenerateReport(string data)
        {
            _generator.GenerateReport(data);
        }
    }
}
