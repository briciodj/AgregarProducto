using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregarProductos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string PROD;
            int CAN = 0;
            int FI = 0;
            double PRE = 0;
            double TOT = 0;
            double PAGA = 0;
            char OP;
            string linea;
            FI = 6;
            PAGA = 0;
            Console.WriteLine("************ AGREGAR PRODUCTOS *****************");
            Console.SetCursorPosition(5, 4);
            Console.Write("PRODUCTO  CANTIDAD  PRECIO  TOTAL");
            do
            {
                Console.SetCursorPosition(5, FI);
                PROD = Console.ReadLine();

                Console.SetCursorPosition(17, FI);
                linea = Console.ReadLine();
                CAN = int.Parse(linea);

                Console.SetCursorPosition(25, FI);
                linea = Console.ReadLine();
                PRE = int.Parse(linea);

                TOT = CAN * PRE;
                Console.SetCursorPosition(33, FI);

                Console.Write(TOT);
                PAGA = PAGA + TOT;
                FI = FI + 1;
                Console.SetCursorPosition(30, 23);
                Console.Write("Otro producto? S/N");
                linea = Console.ReadLine();
                OP = char.Parse(linea.ToUpper());

            } while (OP.ToString().Contains("S"));
            Console.WriteLine("Total a pagar: " + PAGA);
        }
    }
}
