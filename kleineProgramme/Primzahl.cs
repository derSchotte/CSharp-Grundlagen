// Unvollständig

namespace Grundlagen.kleineProgramme {
    internal class Primzahl {
        public static void RunPrimzahl() {
            // Primzahl ist nur durch sich selbst und 1 teilbar
            // zahl1 / zahl1 oder zahl1 / 1 
            
            for( int i = 1; i < 101; i++ ) {
                int zahl = i;

                if( zahl % zahl == 0 && zahl % 1 == 0) {
                    Console.WriteLine(zahl);
                }
            }
        }
    }
}
