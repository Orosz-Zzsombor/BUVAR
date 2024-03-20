using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Búvárrobot_bajnoksága
{
    internal class Gyongy
    {
        int x,y,z,e;

        public Gyongy(String txtsor)
        {
            var mezo = txtsor.Split(";");   
            this.X = int.Parse(mezo[0]);
            this.Y = int.Parse(mezo[1]);
            this.Z = int.Parse(mezo[2]);
            this.E = int.Parse(mezo[3]);
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Z { get => z; set => z = value; }
        public int E { get => e; set => e = value; }

        public double Tavolsag(Gyongy A, Gyongy B)
        {
            
            double tav = Math.Sqrt(Math.Pow(B.X - A.X),2)+Math.Pow(B.Y - A.Y),2)+ (B.Z - A.Z))

            return tav;
        }
    }
}
