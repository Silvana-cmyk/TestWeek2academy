using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeek2Academy.Entities;

namespace TestWeek2Academy
{
    class Operazioni
    {
        public static int MenuInterattivo()
        {
            Console.WriteLine("1. Crea nuovo account");
            Console.WriteLine("2. Versamneto");
            Console.WriteLine("3. Prelievo");
            Console.WriteLine("4. Stampa dati");
            Console.WriteLine("0. premi 0 per uscire");

            int scelta = 0;

            try
            {
                scelta = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                scelta = 99;
            }

            while (scelta < 0 || scelta > 4)
            {
                Console.WriteLine();
                Console.WriteLine("Inserisci un valore corretto.");
                Console.WriteLine();
                break;
            }

            return scelta;
        }

        public static void AnalizzaScelta(int scelta, List<Account> lista)
        {

            switch (scelta)
            {
                case 1:
                    CreaAccount(lista);
                    break;
                case 2:
                    VersamentoPrelievo(lista, "versamento");
                    break;
                case 3:
                    VersamentoPrelievo(lista, "prelievo");
                    break;
                case 4:
                    StampaDati(lista);
                    break;
                case 99:
                    scelta = MenuInterattivo();
                    break;
                default:
                    scelta = 0;
                    break;
            }

        }

        private static void CreaAccount(List<Account> lista)
        {
            try
            {
                Console.WriteLine("Inserisci Numero Conto");
                string numeroConto = Console.ReadLine();
                Console.WriteLine("Inserisci Nome Banca");
                string nomeBanca = Console.ReadLine();
                Console.WriteLine("Inserisci Saldo");
                double saldo = Convert.ToDouble(Console.ReadLine());
                Account account = new Account(numeroConto, nomeBanca, saldo);
                lista.Add(account);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void VersamentoPrelievo(List<Account> lista, string s)
        {
            try
            {

                int i = 0;
                Console.WriteLine("Scegli account");
                foreach (Account item in lista)
                {
                    Console.WriteLine(i + ". " + item.NumeroConto);
                    i++;
                }
                int r = Convert.ToInt32(Console.ReadLine());
                Account temp = lista[r]; //punta all'account a cui vogliamo fare un versamento/prelievo

                Console.WriteLine("Inserisci tipologia di movimento");
                Console.WriteLine("1. Cash movement");
                Console.WriteLine("2. Credit card movement");
                Console.WriteLine("3. Transfert movement");
                int ii = Convert.ToInt32(Console.ReadLine());
                while (ii < 1 || ii > 3)
                {
                    Console.WriteLine("inserisci valore corretto!");
                    ii = ii = Convert.ToInt32(Console.ReadLine());
                }
                if (ii == 1)
                {
                    Account temp2;
                    Console.WriteLine("Inserisci Saldo");
                    double importo = Convert.ToDouble(Console.ReadLine());
                    DateTime data = DateTime.Now;
                    Console.WriteLine("Inserisci esecutore");
                    string esecutore = Console.ReadLine();
                    CashMovement mov = new CashMovement(importo, data, esecutore);
                    if (s.Equals("versamento"))
                    {
                        temp2 = temp + mov;
                    }
                    else
                    {
                        temp2 = temp - mov;
                    }
                    Console.WriteLine(mov.ToString());
                    Console.WriteLine(temp2.ToString());
                }
                else if (ii == 2)
                {
                    Account temp2;
                    Console.WriteLine("Inserisci Saldo");
                    double importo = Convert.ToDouble(Console.ReadLine());
                    DateTime data = DateTime.Now;
                    Console.WriteLine("Inserisci tipologia carta");
                    Console.WriteLine("0. AMEX");
                    Console.WriteLine("1. VISA");
                    Console.WriteLine("2. MASTERCARD");
                    Console.WriteLine("3. other");
                    int j = Convert.ToInt32(Console.ReadLine());
                    while (j < 0 || j > 3)
                    {
                        Console.WriteLine("inserisci valore corretto!");
                        j = Convert.ToInt32(Console.ReadLine());
                    }
                    CreditCardMovement mov = new CreditCardMovement(importo, data, (Tipo)j);
                    if (s.Equals("versamento"))
                    {
                        temp2 = temp + mov;
                    }
                    else
                    {
                        temp2 = temp - mov;
                    }
                    Console.WriteLine(mov.ToString());
                    Console.WriteLine(temp2.ToString());
                }
                else
                {
                    Account temp2;
                    Console.WriteLine("Inserisci Saldo");
                    double importo = Convert.ToDouble(Console.ReadLine());
                    DateTime data = DateTime.Now;
                    Console.WriteLine("Inserisci banca origine");
                    string bancaOrigine = Console.ReadLine();
                    Console.WriteLine("Inserisci banca destinazione");
                    string bancaDest = Console.ReadLine();
                    TransfertMovement mov = new TransfertMovement(importo, data, bancaOrigine, bancaDest);
                    if (s.Equals("versamento"))
                    {
                        temp2 = temp + mov;
                    }
                    else
                    {
                        temp2 = temp - mov;
                    }
                    Console.WriteLine(mov.ToString());
                    Console.WriteLine(temp2.ToString());
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void StampaDati(List<Account> lista)
        {
            try
            {
                int i = 0;
                Console.WriteLine("Scegli account");
                foreach (Account item in lista)
                {
                    Console.WriteLine(i + ". " + item.NumeroConto);
                    i++;
                }
                int r = Convert.ToInt32(Console.ReadLine());
                Account temp = lista[r]; //punta all'account che voglio stampare
                temp.Statement();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
