using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_vers_1._1._2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Taschenrechner mwcom (Markus Wegs 05/21");
            Console.WriteLine("Geben sie zwei zahlen ein");
            Console.Write("erste Zahl");
            double zahl1 =
                Convert.ToDouble(Console.ReadLine());
            Console.Write("zweite Zahl");
            //Eingabe der Zahlen
            double zahl2 =
                Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Was möchten sie machen? *= Multipliezieren + = Adieren - = Subtrahiren / = Dividiren");
            char eingabe =
                Convert.ToChar(Console.ReadLine());
            //Auswählen der Operation
            switch (eingabe)//Beginn der Switch Anweisung

            {

                case '*'://case 1 zum Multiplizieren

                    Console.WriteLine("nn" + (zahl1) + " * " + (zahl2) + " ist: " + (zahl1 * zahl2));

                    break;

                case '+'://case 2 zum Addieren

                    Console.WriteLine("nn" + (zahl1) + " + " + (zahl2) + " ist: " + (zahl1 + zahl2));

                    break;

                case '-'://case 3 zum Subtrahieren

                    Console.WriteLine("nn" + (zahl1) + " - " + (zahl2) + " ist: " + (zahl1 - zahl2));

                    break;

                case '/'://case 4 zum Dividieren

                    Console.WriteLine("nn" + (zahl1) + " / " + (zahl2) + " ist: " + (zahl1 / zahl2));

                    break;



                default://wird ausgegeben wenn ein ungültiges Zeichen eingegeben wird

                    Console.WriteLine("nSie dürfen nur *,+,-,/ eingeben");

                    break;

            }



            Console.ReadLine();



        }

    }

}