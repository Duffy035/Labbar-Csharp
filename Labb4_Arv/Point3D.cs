using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb3;

namespace Labb4_Arv
{
    class Point3D : Point
    {
        private int z;

        public int Z
        {
            get { return z; }
            set { z = value; }
        }


        public Point3D()
        {
            //base.X = X;
            //base.Y = Y;
            Z = 300;
        }
        public Point3D(int x, int y, int z)
        {
            //X = x;
            //Y = y;
            Z = z;
        }

        //public override string ToString() => $"X är: {X}, Y är: {Y}, Z är: {Z}";
        public override string ToString() => $"Z är: {Z}, {base.ToString()}";
    }
}