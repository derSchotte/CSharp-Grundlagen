namespace Grundlagen.kleineProgramme {
    internal class ReverseInput {
        public static void runReverseInput() {
            // Gebe folgendes in der Console aus.
            Console.WriteLine( "Gebe bitte eine Binärzahl ein!" );

            // Initialisiere Integer "binaer" und Deklariere mit der consoleneingabe.
            // Welche durch Int32.Parse gefiltert wird und in Integer umgewandelt wird.
            int binaer = int.Parse(Console.ReadLine());
            // Initialisiere Integer "rueckwaerts" und Deklariere mit dem wert 0
            int rueckwaerts = 0;

            // WHILE-SCHLEIFE
            // Solange binaer größer ">" als 0 ist, mache folgendes
            while( binaer > 0 ) {

                // Initialisiere Integer "restbetrag" und Deklariere mit dem Wert binaer modulo 10 ( binär geteilt durch 10 )
                int restbetrag = binaer % 10;
                // Gebe folgendes in der Console aus...
                Console.WriteLine( $"Restbetrag: {restbetrag}" );

                // Declariere "rueckwaerts" mit (rueckwaerts * 10) plus restbetrag...
                rueckwaerts = ( rueckwaerts * 10 ) + restbetrag;
                // Gebe folgendes in der Console aus...
                Console.WriteLine( $"Rückwärts: {rueckwaerts}" );

                // Declariere "binaer" mit (binaer geteilt durch 10)...
                binaer = binaer / 10;
                // Gebe folgendes in der Console aus...
                Console.WriteLine( $"Binär: {binaer}" );
            }

            // Gebe in der Console die Variable rueckwaerts aus!
            Console.WriteLine( $"Rückwärts Binär ist: {rueckwaerts}" );
        }
    }
}
