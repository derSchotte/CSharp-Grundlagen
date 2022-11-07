namespace Grundlagen.kleineProgramme {
    internal class BubbleSort {
        public static void runBubbleSort() {
            int[] mixedArray = {23,5,7,12,45,13,88, 234,67, 34};
            int temp = 0;

            foreach( int p in mixedArray ) {
                Console.Write( $"[{p}], " );
            }
            Console.WriteLine( "\n" );

            for( int j = 0; j < mixedArray.Length; j++ ) {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine( $"Durchgang J: '{j}'" );

                for( int i = 0; i < mixedArray.Length - 1; i++ ) {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine( $"Durchgang I: '{i}'" );

                    if( mixedArray[ i ] > mixedArray[ i + 1 ] ) {
                        temp = mixedArray[ i + 1 ];

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine( $"Lege Index {i + 1} in Temp: {mixedArray[ i + 1 ]}" );

                        mixedArray[ i + 1 ] = mixedArray[ i ];

                        Console.WriteLine( $"Lege Index {i} in Index {i + 1}: {mixedArray[ i ]}" );

                        mixedArray[ i ] = temp;

                        Console.WriteLine( $"Lege Temp in index {i}: {temp}" );
                        Console.ResetColor();

                        int c = 0;
                        foreach( int p in mixedArray ) {
                            Console.Write( $"{c++}[{p}], " );
                        }
                    } else {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine( $"Index {i} ist nicht größer als {i + 1}" );
                        Console.ResetColor();
                    }

                    Console.Write( "\n\n" );
                }
            }

            Console.WriteLine( "Bubble sort array:" );

            foreach( int p in mixedArray ) {
                Console.Write( p + " " );
            }
        }
    }
}
