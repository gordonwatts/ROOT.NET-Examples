using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicObjectCreation
{
    /// <summary>
    /// Create an object dynamically. Note that this program has a dependence ONLY on the
    /// dynamic ROOT.NET library. This means pretty much the only wrapper in here are some basic
    /// TObject like objects. Everything else doesn't have a wrapper - like TObjString.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var s = ((dynamic)ROOTNET.Utility.ROOTCreator.ROOT).TObjString("dude");
            s.Print();
            // Prints out "dude".
        }
    }
}
