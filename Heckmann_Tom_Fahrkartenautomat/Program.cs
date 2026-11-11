using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heckmann_Tom_Fahrkartenautomat
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           int eingabe = 5;
            while (eingabe != 3)
            { Console.WriteLine("== RheineMobil ==");
            Console.WriteLine("1 - Fahrkarte kaufen");
            Console.WriteLine("2 - Tarifübersicht");
            Console.WriteLine("0 - Beenden");
                eingabe = Convert.ToInt32(Console.ReadLine());
                switch (eingabe)

                {
                    case 2:
                        Console.WriteLine("Tarifübersicht");
                        eingabe = 3;
                        break;
                        
                    case 1:
                        Console.WriteLine("Tarifübersicht");
                        eingabe = 3;
                        break;
                        
                    case 0:
                        Console.WriteLine("Auf Wiedersehen");
                        eingabe = 3;
                        break;
                    default:
                        Console.WriteLine("Ungültige Auswahl!");
                        eingabe = 5;
                        break;
                }
            }
        }
    }
}
