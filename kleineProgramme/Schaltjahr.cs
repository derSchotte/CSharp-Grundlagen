
namespace Grundlagen.kleineProgramme {
    internal class Schaltjahr {
        public static void RunSchaltjahr() {
            // Weil die astronomische Dauer eines Jahres( wenn die Erde die Sonne einmal umrundet
            // hat ) etwas länger ist als 365 Tage, wurden Schaltjahre zum Ausgleich eingeführt.

            // Ein Schaltjahr ist ein Jahr, welches eine Jahreszahl hat, die durch 4 teilbar ist.
            // Jahreszahlen, die durch 100 teilbar sind, sind allerdings keine Schaltjahre. Es sei denn,
            // die Jahreszahl ist durch 400 teilbar.

            // Erstellen Programm, welches prüft, ob eine eingegebene Jahresziffer ein Schaltjahr ist
            // oder nicht und anschließend eine entsprechende Antwort ausgibt.

            Console.WriteLine( "Geben Sie bitte eine Jahreszahl ein!" );
            int jahr = int.Parse( Console.ReadLine() );
            Console.WriteLine( "Bis zu welchem Jahr soll geschaut werden?" );
            int endJahr = int.Parse( Console.ReadLine() );

            for( int i = jahr; i <= endJahr; i++ ) {
                if( ( i % 4 ) == 0 && ( i % 100 ) != 0 || ( i % 4 ) == 0 && ( i % 100 ) == 0 && ( i % 400 ) == 0 ) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine( $"Das Jahr: {i} ist ein Schaltjahr" );
                    Console.WriteLine( $"Jahr: {i} % 4: {i % 4} == 0 | Jahr: {i} % 400: {i % 400} == 0: {( i % 4 ) == 0} | {( i % 400 ) == 0}" );
                } else {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine( $"Das Jahr: {i} ist kein Schaltjahr" );
                    Console.WriteLine( $"Jahr: {i} % 100: {i % 100} != 0: {( i % 100 ) != 0}" );
                }
            }
        }
    }
}
