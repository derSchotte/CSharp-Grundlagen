namespace Grundlagen.kleineProgramme {
    internal class BinToDez {
        public static void runBinToDezimal() {
            // Gebe in der Console folgenden Text aus per Console.WriteLine
            Console.WriteLine( "Gib eine Binäre Zahl ein!" );
            // Initialisiere Integer binaer und Deklariere mit int.Parse(Console.ReadLine()) --- Die Eingabe aus der Console wird gefiltert und in eine "Ganzzahl" umgewandelt.
            int binaer = int.Parse( Console.ReadLine() );
            // Initialisiere Integer dezValue und Deklariere mit wert 0
            int dezValue = 0;
            // Initialisiere Integer base1 und Deklariere mit dem wert 1
            int base1 = 1;

            // #ACHTUNG - Ab hier beginnt die Funktion Convert.ToInt32(<binärfolge>, 2)
            // WHILE-SCHLEIFE
            // Solange binaer größer als 0 ist, mache folgendes
            while( binaer > 0 ) {
                // Initialisiere Integer reminder und Deklariere mit binaer % 10 ( binaer / 10 ? Rest 1 : 0 )
                int reminder = binaer % 10;
                // Gebe in der Console die Variable zurück...
                Console.WriteLine( $"Reminder: {reminder}" );

                // Nehme Variable binear und teile diese durch 10 und Deklariere binaer -- Man könnte hier auch schreiben binaer /= 10;
                binaer = binaer / 10;
                // Gebe in der Console die Variable zurück...
                Console.WriteLine( $"Binär: {binaer}" );

                // Nehme Variable dezValue = (reminder * base1) + (reminder * base1)
                dezValue += reminder * base1;
                // Gebe in der Console die Variable zurück...
                Console.WriteLine( $"Dezimal: {dezValue}" );

                // Power of Two
                // Nehme Varaible base1 und nehme base1 mal 2 und Deklariere base1
                // DURCHGÄNGE: 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024...
                // Wobei 1 als erstes oben Initialisiert und Deklariert wurde. Denn Power of 2 kann niemals mit 0 beginnen
                base1 = base1 * 2;
                // Gebe in der Console die Variable zurück...
                Console.WriteLine( $"Base: {base1}" );
            }
            // Gebe in der Console die Variable zurück...
            Console.WriteLine( $"Dezimal: {dezValue}" );
        }
    }
}
