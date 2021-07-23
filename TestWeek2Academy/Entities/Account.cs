using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek2Academy.Entities
{
    public class Account
    {
        public string NumeroConto { get; set; }
        public string NomeBanca { get; set; }
        public double Saldo { get; set; }
        public DateTime DataUltimaOperazione { get; set; }
        public List<Movement> Movimenti { get; set; } = new List<Movement>();

        public Account(string nc, string nb, double s)
        {
            NumeroConto = nc;
            NomeBanca = nb;
            Saldo = s;
            DataUltimaOperazione = DateTime.Now; //viene creato l'account
        }

        public Account Somma(Movement movement)
        {
            this.Movimenti.Add(movement);
            this.Saldo = this.Saldo + movement.Importo;
            DataUltimaOperazione = movement.DataMovimento;
            return this;
        }

        public static Account operator +(Account a, Movement m)
        {
            return a.Somma(m);
        }

        public Account Differenza(Movement movement)
        {
            this.Movimenti.Add(movement);
            this.Saldo = this.Saldo - movement.Importo;
            DataUltimaOperazione = movement.DataMovimento;
            return this;
        }

        public static Account operator -(Account a, Movement m)
        {
            return a.Differenza(m);
        }

        public void Statement()
        {
            Console.WriteLine($"Numero Conto: {NumeroConto}; Nome Banca: {NomeBanca}; Saldo: {Saldo} " +
                $"Data Ultima Operazione {DataUltimaOperazione} .");
            foreach(var item in Movimenti)
            {
                Console.WriteLine("Movimento: " + "Importo tot:" + item.Importo + " Data movimento: " + item.DataMovimento);
            }
        }

        public override string ToString()
        {
            string s = "";
            s = s + $"Numero Conto: {NumeroConto}; Nome Banca: {NomeBanca}; Saldo: {Saldo} " +
                $"Data Ultima Operazione {DataUltimaOperazione} .";
            foreach (var item in Movimenti)
            {
                s = s  + "Movimento : " + "Importo tot:" + item.Importo + " Data movimento: " + item.DataMovimento;
            }
            return s;
        }
    }
}
