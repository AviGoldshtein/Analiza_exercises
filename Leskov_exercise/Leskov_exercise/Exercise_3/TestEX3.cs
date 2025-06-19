using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leskov_exercise.Exercise_3
{
    internal class TestEX3 : Itest
    {
        public void Run()
        {
            DocumentExporter documentExporter = new DocumentExporter();
            documentExporter.ExportToPDF();

            OnlineExporter onlineExporter = new OnlineExporter();
            onlineExporter.ExportOnline();
        }
    }
}
