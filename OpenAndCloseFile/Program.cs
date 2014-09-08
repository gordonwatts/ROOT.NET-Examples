using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenAndCloseFile
{
    /// <summary>
    /// Sample program that will open and close a ROOT file,
    /// and write a TObjString to it.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Create the file
            {
                Console.WriteLine("Creating a file:");
                var f = ROOTNET.NTFile.Open("../../../OpenAndCloseFile.root", "RECREATE");
                var s = new ROOTNET.NTObjString("my left foot");
                f.Add(s);
                f.Write();
                f.Close();
            }

            // Open it and dump it out
            {
                Console.WriteLine("\n\nOpening and dumping out the contents of the same file:");
                var f = ROOTNET.NTFile.Open("OpenAndCloseFile.root", "READ");
                f.ls();
                f.Close();
            }
        }
    }
}
