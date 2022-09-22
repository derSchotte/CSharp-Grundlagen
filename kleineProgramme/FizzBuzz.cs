namespace Grundlagen.kleineProgramme {
    internal class FizzBuzz {
        public static void runFizzBuzz() {
            // Gebe einen Text in der Console aus mit Console.WriteLine()
            Console.WriteLine( "Geben sie die länge an!" );
            // Initialisiere laenge und Deklariere mit Inhalt aus der Consoleneingabe. -- Filter die Eingabe der Console "String" und wandel diese in ein Integer um
            var laenge = Int32.Parse( Console.ReadLine() );

            // for ( Initialisiere I und Deklariere mit 0; Frage "IST" i kleiner "<" als laenge; "WENN" i kleiner laenge dann i = i + 1 zusammengefasst "i++";
            for( int i = 0; i < laenge; i++ ) {
                // IF-ANWEISUNG -- ELSE IF-ANWEISUNG -- ELSE-ANWEISUNG
                // Ist die Zahl i restlos durch 15, 5 oder 3 teilbar... Wenn ja gebe in Console aus... Wenn Nein, gehe zur nächsten Anweisung.
                // Wenn i % (3*5) oder 15 restwert 0 ist...
                if( i % ( 3 * 5 ) == 0 ) {
                    // Dann gebe folgenden Text in der Console aus.
                    Console.WriteLine( "FizzBuzz" );
                    // Wenn i % 5 restwert 0 ist...
                } else if( i % 5 == 0 ) {
                    // Dann gebe folgenden Text in der Console aus.
                    Console.WriteLine( "Buzz" );
                    // Wenn i % 3 restwert 0 ist...
                } else if( i % 3 == 0 ) {
                    // Dann gebe folgenden Text in der Console aus.
                    Console.WriteLine( "Fizz" );
                } else {
                    // Sollte die Zahl nicht durch 15, 5 oder 3 restlos teilbar sein... Dann gebe die Zahl in der Console aus.
                    Console.WriteLine( i );
                }
            }
        }
    }
}
