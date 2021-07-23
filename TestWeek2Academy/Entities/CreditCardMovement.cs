using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek2Academy.Entities
{
    public enum Tipo
    {
        AMEX,
        VISA, 
        MASTERCARD,
        OTHER
    }
    public class CreditCardMovement : Movement
    {
        public double Importo { get; set; }
        public DateTime DataMovimento { get; set; }
        public Tipo Tipo { get; set; }

        public CreditCardMovement(double d, DateTime dt, Tipo t)
        {
            Importo = d;
            DataMovimento = dt;
            Tipo = t;
        }

        public override string ToString()
        {
            return $"Importo: {Importo}; Data movimento: {DataMovimento}; Tipo: {Tipo}";
        }

    }
}
