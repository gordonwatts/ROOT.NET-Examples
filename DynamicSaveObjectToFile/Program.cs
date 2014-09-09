using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicSaveObjectToFile
{
    /// <summary>
    /// Create a root object dynamically, and then write it to a file.
    /// Wrappers for TObjString and TFile are not linked in (the core package isn't linked
    /// for this project).
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var s = ((dynamic)ROOTNET.Utility.ROOTCreator.ROOT).TObjString("dude");
            var f = ((dynamic)ROOTNET.Utility.ROOTCreator.ROOT).TFile("../../../DynamicSaveObjectToFile.root", "RECREATE");
            f.Add(s);
            f.Write();
            f.Close();
        }
    }
}
