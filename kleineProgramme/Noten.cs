using System.Runtime.CompilerServices;

namespace Grundlagen.kleineProgramme {
    internal class Noten {
        public static void runNoten() {
            // Initialisiere string als Array "fach" und Deklariere es mit einem neuen stringarray + Inhalt
            string[] fach = new string[] {"Deutsch", "Englisch", "Mathe"};
            //Initialisiere Integer als Array "noten" und Deklariere es mit einem neuen intarray ohne Inhalt.
            int[] noten = new int[] { };
            Console.WriteLine( RuntimeHelpers.GetHashCode( noten ) );
            // Initialisiere float gesamt und Deklariere mit 0
            float gesamt = 0;

            // FOREACH-SCHLEIFE
            // Für jedes Element in Elemente... mache folgendes
            foreach( string element in fach ) {
                // Gebe das Array Fach erstes {element} in der Console aus [0]"Fach: Deutsch" ... [1]"Fach: Englisch" ... [2]"Fach: Mathe"
                Console.WriteLine( $"Fach: {element}" );
                // Initialisiere var eingabe und Deklariere mit Eingabe aus der Console
                var eingabe = Console.ReadLine();

                // Nehme noten und führe folgende Funktionen aus...
                // noten.Concat() - Füge für "jedes Fach" die eingegebene "note" an das ende ein. Deutsch <- Englisch <- Mathe
                // new[] {<inhalt>} ist dazu gedacht um die Eingaben von einander zu trennen, damit diese in das Array noten eingefügt werden können.
                // Ohne diese würde nur ein Wert im Array stehen mit 3 noten an Platz 0
                // Int32.Parse - Filter die Consoleneingabe und wandel in ein Integer um.
                // .ToArray(); - Übergebe die noten in das Array.

                noten = noten.Concat( new[] { Int32.Parse( eingabe ) } ).ToArray();
                Console.WriteLine( RuntimeHelpers.GetHashCode( noten ) );
            }
            // for ( Initialisiere I und Deklariere mit 0; Frage "IST" i kleiner "<" als noten.length; "WENN" i kleiner noten.length dann i = i + 1 zusammengefasst "i++";
            for( int i = 0; i < noten.Length; i++ ) {
                // Addiere alle noten im array noten zusammen. Die Position innerhalb des Arrays wird durch i angegeben. Beginnend bei 0
                // Die Variable gesamt entählt dadurch alle addierten noten.
                gesamt += noten[ i ];
            }

            // IF-ANWEISUNG
            // Wenn (gesamt geteilt noten.length) kleiner als 4 ist....
            if( ( gesamt / noten.Length ) < 4 ) {
                // dann gebe in der Console folgenden Text aus
                Console.WriteLine( $"Der Notendurchschnitt ist {( gesamt / noten.Length )}, die Versetzung ist nicht gefährdet" );
            } else {
                // Ist der Notendurchschnitt größer als 4... dann gebe folgenden Text aus.
                Console.WriteLine( "Setzten, Lernen, Wiederholen" );
            }
        }
    }
}