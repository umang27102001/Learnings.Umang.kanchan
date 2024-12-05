using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPractice.LSP.Document
{
    public class ReadOnlyDocument : IReadonlyDocument
    {
        public string Content { get; }

        public string Read()
        {
            return Content;
        }
    }
}
