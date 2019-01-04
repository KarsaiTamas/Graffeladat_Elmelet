using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafFeladat_CSharp
{
    class Szotar
    {
        public Csucs csucs { get; set; }
        public int szin { get; set; }

        public Szotar(Csucs csucs,int szin)
        {
            this.csucs = csucs;
            this.szin = szin;
        }

        public override string ToString()
        {
            return String.Format("{0}-csúcs {1} szinű",csucs,szin);
        }
    }
}
