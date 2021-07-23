using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek2Academy.Entities
{
    public class CashMovement : Movement
    {
        public double Importo { get; set; }
        public DateTime DataMovimento { get; set; }
        public string Esecutore { get; set; }
        public CashMovement(double d, DateTime dt, string e)
        {
            Importo = d;
            DataMovimento = dt;
            Esecutore = e;
        }

        public override string ToString()
        {
            return $"Importo: {Importo}; Data movimento: {DataMovimento}; Esecutore: {Esecutore}";
        }

    }
}
