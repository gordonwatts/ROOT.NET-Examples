using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicSaveObjectToFile
{
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
