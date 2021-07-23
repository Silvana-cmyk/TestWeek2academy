using System;
using System.Collections.Generic;
using TestWeek2Academy.Entities;

namespace TestWeek2Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> listaA = new List<Account>();
            int i = Operazioni.MenuInterattivo();
            while (i != 0)
            {
                Operazioni.AnalizzaScelta(i, listaA);
                i = Operazioni.MenuInterattivo();
            }

        }
    }
}
