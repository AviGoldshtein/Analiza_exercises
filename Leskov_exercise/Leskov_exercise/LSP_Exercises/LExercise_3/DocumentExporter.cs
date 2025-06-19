using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leskov_exercise.Exercise_3
{
    internal class DocumentExporter : IPdfExportable
    {
        public virtual void ExportToPDF()
        {
            Console.WriteLine("ExportToPDF");
        }
    }
}
