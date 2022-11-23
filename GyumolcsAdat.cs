using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace GyumolcsokGyak
{
    internal class GyumolcsAdat
    {

        int id;
        string gyumolcsnev;
        double mennyiseg;
        double egysegar;

        public int Id { get => id; set => id = value; }
        public string Gyumolcsnev { get => gyumolcsnev; set => gyumolcsnev = value; }
        public double Mennyiseg { get => mennyiseg; set => mennyiseg = value; }
        public double Egysegar { get => egysegar; set => egysegar = value; }

        public GyumolcsAdat(int id, string gyumolcsnev, double mennyiseg, double egysegar)
        {
            Id = id;
            Gyumolcsnev = gyumolcsnev;
            Mennyiseg = mennyiseg;
            Egysegar = egysegar;
        }

        public override string ToString()
        {
            return Gyumolcsnev + " " + Mennyiseg + " " + Egysegar;
        }

    }
}
