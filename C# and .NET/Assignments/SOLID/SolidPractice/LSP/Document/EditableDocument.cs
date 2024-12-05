using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPractice.LSP.Document
{
    public class EditableDocument : IReadonlyDocument, IWriteOnlyDocument
    {
        public String Content { get; set; }
        public string Read()
        {
            return Content;
        }
        public void Write(string content)
        {
            Content = content;
        }
    }
}