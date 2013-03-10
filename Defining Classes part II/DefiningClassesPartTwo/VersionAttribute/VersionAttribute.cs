using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*11.	Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods
 * and holds a version in the format major.minor (e.g. 2.11).
 * Apply the version attribute to a sample class and display its version at runtime.*/
namespace VersionAttribute
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface 
        | AttributeTargets.Method | AttributeTargets.Enum, AllowMultiple = true)]

    public class VersionAttribute : System.Attribute
    {
        private string name;
        private int minor;
        private int major;

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public int Major
        {
            get
            {
                return this.major;
            }

            set
            {
                this.major = value;
            }
        }

        public int Minor
        {
            get
            {
                return this.minor;
            }

            set
            {
                this.minor = value;
            }
        }

        public VersionAttribute(string name, int major, int minor)
        {
            this.name = name;
            this.major = major;
            this.minor = minor;
        }
    }
}
