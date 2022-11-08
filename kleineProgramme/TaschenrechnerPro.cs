namespace Grundlagen.kleineProgramme {
    internal class TaschenrechnerPro {
        public static void RunTaschenrechnerPro() {
            //  Schreiben Sie ein Programm, das zwei Zahlen einliest und anschließend mit Hilfe
            //  einer Switch - Anweisung ein Menü anbietet, in welchem der Benutzer zwischen
            //  den 4 Grundrechnungsarten wählen kann. Inkludieren Sie einen Menüpunkt für
            //  einen Abbruch des Programmes.

            //  Nach entsprechender Wahl soll der Anwender das Ergebnis( wenn mathematisch möglich)
            //  ausgegeben bekommen.

            //  Nach der Ausgabe der Berechnung soll das Programm automatisch von neuem starten.

            decimal eingabe1;
            decimal eingabe2;
            decimal endErgebnis = 0;
            string operatoren;

            do {
                Console.Clear();
                Console.Write( "Geben Sie bitte die erste Zahl ein: " );
                eingabe1 = int.Parse( Console.ReadLine() );
                Console.Write( "Geben sie bitte den Operator ein ( + | - | * | / ): " );
                operatoren = Console.ReadLine();
                Console.Write( "Geben Sie bitte die zweite Zahl ein: " );
                eingabe2 = int.Parse( Console.ReadLine() );

                switch( operatoren ) {
                    case "+":
                    endErgebnis = Berechnung( eingabe1, eingabe2, operatoren );
                    break;
                    case "-":
                    endErgebnis = Berechnung( eingabe1, eingabe2, operatoren );
                    break;
                    case "*":
                    endErgebnis = Berechnung( eingabe1, eingabe2, operatoren );
                    break;
                    case "/":
                    endErgebnis = Berechnung( eingabe1, eingabe2, operatoren );
                    break;
                    default:
                    Console.WriteLine( "Sie haben den falschen Operator eingetragen" );
                    break;
                }
                Console.WriteLine( $"\nErgebnis: {eingabe1} {operatoren} {eingabe2} = {endErgebnis}\n\n" );
                Console.WriteLine( "Zum verlassen des Taschenrechners 'ESC' Taste drücken oder beliebige Taste für weiter!" );
            } while( Console.ReadKey().Key != ConsoleKey.Escape );
        }

        private static decimal Berechnung( decimal eingabe1, decimal eingabe2, string operatoren ) {
            decimal ergebnis = 0;

            if( operatoren == "+" ) {
                ergebnis = eingabe1 + eingabe2;
            } else if( operatoren == "-" ) {
                ergebnis = eingabe1 - eingabe2;
            } else if( operatoren == "*" ) {
                ergebnis = eingabe1 * eingabe2;
            } else if( operatoren == "/" ) {
                if( eingabe2 == 0 ) { return 0; }

                ergebnis = eingabe1 / eingabe2;
            }

            return ergebnis;
        }
    }
}
