namespace Grundlagen.kleineProgramme {
    internal class BinToDez2 {
        public static void runBinToDezimal2() {
            //Initialisiere Integer output und Deklariere mit dem wert 0
            int output = 0;
            // Initialisiere string binary und Deklariere mit einem leeren string ""
            string binary = "";

            // Gebe einen Text in der Console aus mit WriteLine
            Console.WriteLine( "Gib eine Binärzahl ein! (Maximal 8 Zeichen)" );

            // Initialisiere den Boolischen Operator mit dem wert false ("NICHT WAHR") --- bool oder boolean kann nur false ("FALSCH") oder true ("WAHR") beinhalten.
            bool isOk = false;

            // WHILE-SCHLEIFE
            // Solange isOk nicht wahr ist, führe aus...
            while( !isOk ) {
                // Erwarte eine Eingabe in der Console und Deklariere binary mit der Consoleneingabe.
                binary = Console.ReadLine();

                // IF-ANWEISUNG
                // IST binary.length größer 8 dann...
                if( binary.Length > 8 ) {
                    // ... gebe in der Console folgenden Text aus...
                    Console.WriteLine( "Die Eingabe war zu lang!" );
                    // andernfalls mache folgendes
                } else {
                    // Setzte die boolische Variable auf true "WAHR"
                    isOk = true;
                }
            }

            // TRY - CATCH = Versuche folgendes oder gebe fehler aus....
            // Versuche...
            try {
                // Deklariere output mit der Funktion Convert.ToInt32
                // Hierbei wird per Funktion die binärische Zahl in eine Dezimalzahl umgewandelt.
                output = Convert.ToInt32( binary, 2 );
                // Sollte dieses nicht funktionieren dann gebe einen Fehler aus...
            } catch( Exception ) {
                // Gebe in der Console folgendenden Text aus...
                Console.WriteLine( "Das war keine Binärzahl!" );
            }

            // Wenn TRY-CATCH erfolgreich war dann gebe in der Console aus...
            Console.WriteLine( $"Die von Ihnen eingegebene Binärzahl '{binary}' ergibt Dezimal '{output}'" );
        }
    }
}
