using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SolidPractice.LSP.Document
{
    public interface IReadonlyDocument { 
        string Content { get; }
        string Read();
    }
}
