using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen.kleineProgramme {
    internal class Fibo {
        public static void RunFibo() {
            // Schleife von 0 - 100
            // Rechnung zahl1 + zahl2 = zahl3, zahle2 + zahl 3 = zahl 4, zahl3 + zahl4 = zahl5
            // Ausgabe
            int ergebnis = 0;
            int zahl1 = 1, zahl2 = 1;

            for( int i = 0; i < 100; i++ ) {
                if(i == 0) { zahl1 = 0; }
                zahl1 += zahl2;
                zahl2 = zahl1 - zahl2;

                ergebnis = zahl1 + zahl2;

                Console.WriteLine( $"Fibo: {zahl1} + {zahl2} = {ergebnis}" );
            }
        }
    }
}
