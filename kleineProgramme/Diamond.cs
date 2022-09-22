namespace Grundlagen.kleineProgramme {
    internal class Diamond {
        public static void runDiamond() {
            // Gebe mit console.writeline einen Text aus.
            Console.WriteLine( "Geben sie ein Zeichen ein:" );

            // Initialisiere und Deklariere Eingabe mit Console.ReadLine(); --- Erwarte eine Eingabe
            var eingabe = Console.ReadLine();

            // Initialisiere und Deklariere ausgabe mit einem leeren String.
            var ausgabe = "";

            // Initialisiere und Deklariere length mit 0.
            var length = 0;

            // Initialisiere den Boolischen Operator mit dem wert false ("NICHT WAHR") --- bool oder boolean kann nur false ("FALSCH") oder true ("WAHR") beinhalten.
            bool isOdd = false;

            // WHILE-SCHLEIFE
            // Solange isOdd nicht wahr ist, führe aus...
            while( !isOdd ) {
                // Gebe den Text in der Console aus.
                Console.WriteLine( "Geben sie die größe der mitte an! (Bitte nur ungerade Zahlen)" );
                // Initialisiere und Deklariere lengthInput mit Int32.Parse und Console ReadLine. --- Um sicherzustellen das nur "Ganzzahlen" in unserer Länge verarbeitet werden. Filtern wir es durch den Befehle Int32.Parse
                // Hier ist allerdings noch kein FailSafe eingebaut das nur Ungerade Zahlen verwendet werden können. Folgt in der IF-Anweisung
                var lengthInput = Int32.Parse(Console.ReadLine());

                // IF-ANWEISUNG
                // Teile lengthInput durch 2 und wenn rest = 0....
                if( lengthInput % 2 == 0 ) {
                    // .... dann gebe den Nachfolgenden Text aus.....
                    Console.WriteLine( "Sie haben eine gerade Zahl eingegeben!" );
                    // ..... andernfalls
                } else {
                    // Deklariere die Variable length mit dem Inhalt lengthInput.
                    length = lengthInput;
                    // Setzte den boolischen wert isOdd auf "WAHR" damit die Schleife verlassen wird.
                    isOdd = true;
                }
            }

            // for ( Initialisiere I und Deklariere mit 0; Frage "IST" i kleiner "<" als 5; "WENN" i kleiner 5 dann i = i + 1 zusammengefasst "i++";
            for( int i = 0; i < length; i++ ) {
                // "WENN" i kleiner 5 ...
                if( i < length ) {
                    // ... "DANN" für aus
                    // ausgabe = ausgabe + eingabe; zusammengefasst "ausgabe += eingabe;"
                    ausgabe += eingabe;
                }
            }

            // Initialisiere und Deklariere zeichen mit der variable ausgabe.
            string zeichen = ausgabe;
            // Initialisiere Integer l und Deklariere mit der variable zeichen.length ( wobei .length ) die länge der variable zurückgibt.
            int l = zeichen.Length;
            // Initialisiere Integer c und Deklariere mit der Mathematischen Formel "l / 2 + 1".
            // Beispiel:
            //          7 / 2 = 3.5
            //          3.5 wird zu 3 (da es ein Integer ist)
            //          3 + 1 = 4
            int c = l / 2 + 1; //center

            // Gebe in der Console die Variable Zeichen und die Variable C nach der Berechnung aus.
            Console.WriteLine( $"Zeichen: {zeichen} - Länge: {l} - Center: {c}" );

            // for ( Initialisiere i und Deklariere mit 0; Frage "IST" i kleiner als c; "WENN" i kleiner 5 dann i = i + 1 zusammengefasst "i++";
            for( int i = 0; i < c; i++ ) {
                // Gebe in der Console aus..
                // ERSTER DURCHGANG:SUBSTRING (c - i - 1) = (4 - 1 - 1) = 2  -||-  (i * 2 + 1) = (0 * 2 + 1) = 1
                // ZWEITER DURCHGANG:SUBSTRING (4 - 2 - 1) = 1  -||-  (1 * 2 + 1) = 3

                // ERSTER DURCHGANG:PADLEFT (c + i) = (3 + 0) = 3 // Füge drei leerzeichen ein.
                // ZWEITER DURCHGANG:PADLEFT (c + i) = (3 + 1) = 4 // Füge vier leerzeichen ein.
                Console.WriteLine( zeichen.Substring( c - i - 1, i * 2 + 1 ).PadLeft( c + i, ' ' ) );
            }
            // for ( Initialisiere i und Deklariere mit (c-2); Frage "IST" i größer gleich 0; "WENN" i größer gleich 0, dann i = i - 1 zusammengefasst "i--";
            for( int i = c - 2; i >= 0; i-- ) {
                // Führe die gleiche Operation wie in der vorherigen for-SCHLEIFE aus.
                Console.WriteLine( zeichen.Substring( c - i - 1, i * 2 + 1 ).PadLeft( c + i, ' ' ) );
            }

            for( int i = 0; i < c; i++ ) {
                Console.WriteLine( $"i++, SUBSTRING: c({c}) - i({i}) - 1: {c - i - 1}  -  i({i}) * 2 + 1: {i * 2 + 1}  --  PADLEFT: c({c}) + i({i}): {c + i}" );
            }
            for( int i = c - 2; i >= 0; i-- ) {
                Console.WriteLine( $"i++, SUBSTRING: c({c}) - i({i}) - 1: {c - i - 1}  -  i({i}) * 2 + 1: {i * 2 + 1}  --  PADLEFT: c({c}) + i({i}): {c + i}" );
            }
        }
    }
}