using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen.kleineProgramme {
    internal class BinarySearch {
        public static void RunBinarySeach() {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int search = 5;
            int index = -1;
            int left = 0;
            int right = array.Length - 1;
            while (left <= right) {
                int middle = (left + right) / 2;
                if( array[middle] == search) {
                    index = middle;
                    break;
                } else if( array[middle] < search) {
                    left = middle + 1;
                } else {
                    right = middle - 1;
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
