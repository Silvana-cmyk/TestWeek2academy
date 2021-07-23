using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek2Academy.Entities
{
    public class TransfertMovement : Movement
    {
        public double Importo { get; set; }
        public DateTime DataMovimento { get; set; }
        public string BancaOrigine { get; set; }
        public string BancaDestinazione { get; set; }

        public TransfertMovement(double d, DateTime dt, string bo, string bd)
        {
            Importo = d;
            DataMovimento = dt;
            BancaOrigine = bo;
            BancaDestinazione = bd;
        }

        public override string ToString()
        {
            return $"Importo: {Importo}; Data movimento: {DataMovimento}; Banca Origine: " +
                $"{BancaOrigine} Banca Destinazione {BancaDestinazione}";
        }
    }
}
