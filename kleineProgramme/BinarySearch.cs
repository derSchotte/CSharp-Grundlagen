using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen.kleineProgramme {
    internal class BinarySearch {
        //Die Methode RunBinarySearch() führt eine binäre Suche auf einem Array aus. Das Array enthält die Zahlen von 1 bis 9.
        //Die Zahl, die gesucht wird, ist 5. Der Index des gesuchten Elements wird auf -1 initialisiert.
        //Die Variablen left und right werden auf 0 und die Länge des Arrays - 1 initialisiert. Solange left kleiner oder
        //gleich right ist, wird die Mitte des Arrays berechnet. Wenn das Element an der mittleren Position dem gesuchten Element entspricht,
        //wird der Index auf den Wert der mittleren Position gesetzt und die Schleife wird beendet.
        //Wenn das Element an der mittleren Position kleiner als das gesuchte Element ist,
        //wird left auf die mittlere Position + 1 gesetzt. Wenn das Element an der mittleren Position größer als das gesuchte Element ist,
        //wird right auf die mittlere Position - 1 gesetzt.
        //Wenn der Index nach der Schleife immer noch -1 ist, wird "Element nicht gefunden" ausgegeben, andernfalls wird "Element gefunden an Index x" ausgegeben.
        
        public static void RunBinarySeach() {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int search = 5;
            int index = -1;
            int left = 0;
            int right = array.Length - 1;
            while( left <= right ) {
                int middle = (left + right) / 2;
                if( array[ middle ] == search ) {
                    index = middle;
                    break;
                } else if( array[ middle ] < search ) {
                    left = middle + 1;
                } else {
                    right = middle - 1;
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
