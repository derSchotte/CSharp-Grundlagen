using System.Runtime.ConstrainedExecution;

namespace Grundlagen.kleineProgramme {
    internal class KistenRabatt {
        public static void RunKistenRabatt() {
            // Eine Brauerei gewährt Kunden
            // bei Abnahme von mindestens 10 Kästen 5 % Rabatt
            // bei Abnahme von mindestens 50 Kästen 7 % Rabatt
            // bei Abnahme von mindestens 100 Kästen 10 % Rabatt.

            // Erstellen Sie ein Programm, welches die Eingabe
            // der Menge( in Anzahl Kästen ) erlaubt und dann den Prozentsatz
            // richtig ermittelt und anschliessend ausgibt.

            Console.Write( @"
******************************************
*                                        *
*        Brauerei Holzhobel              *
*                                        *
******************************************
*                                        *
*  Bei abnahme von 10 Kisten: 5% Rabatt  *
*  Bei abnahme von 50 Kisten: 7% Rabatt  *
* Bei abnahme von 100 Kisten: 10% Rabatt *
*                                        *
******************************************
" );
            decimal kostet = 0.00m;

            Console.WriteLine( "Welche Sorte darf es sein?" );
            Console.WriteLine( "Pilz, Klausthaler, Haumichblau" );
            string sorte = Console.ReadLine();

            Console.Write( "Wieviele Kisten Bier dürfen es sein? : " );
            decimal kisten = decimal.Parse(Console.ReadLine());

            switch( sorte ) {
                case "Pilz":
                kostet = 14.99m;
                break;
                case "Klausthaler":
                kostet = 7.99m;
                break;
                case "Haumichblau":
                kostet = 24.99m;
                break;
                default:
                kostet = 200m;
                break;
            }

            if( sorte == "Pilz" || sorte == "Klausthaler" || sorte == "Haumichblau" ) {
                if( kisten >= 10 && kisten < 50 ) {
                    Console.WriteLine( kostet );
                    Console.WriteLine( $"Rabatt: {( ( kostet * kisten ) / 100 ) * 5} Euro" );
                } else if( kisten >= 50 && kisten < 100 ) {
                    Console.WriteLine( kostet );
                    Console.WriteLine( $"Rabatt: {( ( kostet * kisten ) / 100 ) * 7} Euro" );
                } else if( kisten >= 100 ) {
                    Console.WriteLine( kostet );
                    Console.WriteLine( $"Rabatt: {( ( kostet * kisten ) / 100 ) * 10} Euro" );
                } else {
                    Console.WriteLine( $"Entschuldigung, bei {kisten} Kisten gibt es keinen Rabatt" );
                }
            }
        }
    }
}
