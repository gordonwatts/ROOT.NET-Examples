using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillSimpleHistogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Writing out a file containing a single filled histogram");

            var h = new ROOTNET.NTH1F("hi", "there", 100, 0.0, 100.0);
            for (int i = 0; i < 100; i++)
            {
                h.Fill(i, i);
            }

            var f = ROOTNET.NTFile.Open("../../../FillSimpleHistogram.root", "RECREATE");
            f.Add(h);
            f.Write();
            f.Close();
        }
    }
}
