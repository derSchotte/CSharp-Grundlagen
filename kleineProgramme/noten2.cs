using System.Runtime.CompilerServices;

namespace Grundlagen.kleineProgramme {
    internal class noten2 {
        public static void runNoten2() {
            List<string> fach = new();
            List<int> noten = new();
            Console.WriteLine( RuntimeHelpers.GetHashCode( noten ) );
            fach.Add( "Deutsch" );
            fach.Add( "Englisch" );
            fach.Add( "Mathe" );

            float gesamt = 0;

            foreach( string element in fach ) {
                Console.Write( $"Fach {element}: " );
                int eingabe = Int32.Parse(Console.ReadLine());
                noten.Add( eingabe );
                Console.WriteLine( RuntimeHelpers.GetHashCode( noten ) );
            }

            for( int i = 0; i < noten.Count; i++ ) {
                gesamt += noten[ i ];
            }

            if( gesamt / noten.Count < 4 ) {
                Console.WriteLine( $"Der Notendurchschnitt ist {( gesamt / noten.Count )}, die Versetzung ist nicht gefährdet" );
            } else {
                Console.WriteLine( "Setzten, Lernen, Wiederholen" );
            }
        }
    }
}
