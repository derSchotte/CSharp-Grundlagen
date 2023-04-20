using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen.kleineProgramme {
    internal class LinearSearch {
        //Diese Methode führt eine lineare Suche durch. Es wird ein Array mit den Werten 1 bis 9 erstellt und nach dem Wert 5 gesucht.
        //Es wird eine Schleife durchlaufen, um jeden Wert im Array zu überprüfen. Wenn der Wert gefunden wird,
        //wird der Index des Elements gespeichert und die Schleife beendet. Wenn der Wert nicht gefunden wird,
        //wird eine Nachricht ausgegeben, dass das Element nicht gefunden wurde. Wenn der Wert gefunden wird, wird eine Nachricht ausgegeben,
        //an welchem Index das Element gefunden wurde.
        public static void RunLinearSearch() {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int search = 5;
            int index = -1;
            for( int i = 0; i < array.Length; i++ ) {
                if( array[ i ] == search ) {
                    index = i;
                    break;
                }
            }
            if( index == -1 ) {
                Console.WriteLine( "Element nicht gefunden" );
            } else {
                Console.WriteLine( "Element gefunden an Index {0}", index );
            }
            Console.ReadKey();
        }
    }
}
