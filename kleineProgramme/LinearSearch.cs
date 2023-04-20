using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen.kleineProgramme {
    internal class LinearSearch {
        public static void RunLinearSearch() {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int search = 5;
            int index = -1;
            for (int i = 0; i < array.Length; i++) {
                if( array[i] == search) {
                    index = i;
                    break;
                }
            }
            if (index == -1) {
                Console.WriteLine("Element nicht gefunden");
            } else {
                Console.WriteLine("Element gefunden an Index {0}", index);
            }
            Console.ReadKey();
        }
    }
}
