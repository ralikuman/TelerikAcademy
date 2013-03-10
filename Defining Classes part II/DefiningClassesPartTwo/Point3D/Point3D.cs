using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1.	Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. 
 * Implement the ToString() to enable printing a 3D point.*/

/*2.	Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}. 
 * Add a static property to return the point O.*/

namespace Point3D
{
    public struct Point3D
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Z { get; private set; }

        //ex.2 static read-only field to hold zero point
        private static readonly Point3D zero = new Point3D(0, 0, 0);

        public static Point3D Zero
        {
            get { return zero; }
        }

        //constructor 
        public Point3D(int x, int y, int z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        //Implement the ToString() to enable printing a 3D point.
        public override string ToString()
        {
            return String.Format("({0},{1},{2})", X, Y, Z);
        }
    }
}
