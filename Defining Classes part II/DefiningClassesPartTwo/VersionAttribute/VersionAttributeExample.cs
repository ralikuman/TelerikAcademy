using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VersionAttribute
{
    [VersionAttribute("Version", 2, 11)]
    [VersionAttribute("Version", 2, 12)]

    class VersionAttributeExample
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture =
                  CultureInfo.GetCultureInfo("en-US");
            Type type = typeof(VersionAttributeExample);
            object[] versions = type.GetCustomAttributes(false);
            foreach (VersionAttribute version in versions)
            {
                Console.WriteLine("The version of class {0} is {1} {2}.{3} ", type, version.Name,
                    version.Major, version.Minor);
            }
        }
    }
}
