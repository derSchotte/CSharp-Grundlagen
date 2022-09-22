using System.Reflection.Metadata.Ecma335;
using static System.Formats.Asn1.AsnWriter;

namespace Grundlagen.kleineProgramme {
    internal class PerlinNoise {
        public static void runPerlinNoise() {
            int size = 32;
            int density = 50;

            Random rand = new();

            for( int x = 0; x < size; x++ ) {
                for( int y = 0; y < size; y++ ) {
                    int random = rand.Next( 1, 100 );

                    if( random > density ) {
                        Console.SetCursorPosition( x, y );
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write( "#" );
                    } else {
                        Console.SetCursorPosition( x, y );
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write( "#" );
                    }
                }
            }
        }
    }
}
