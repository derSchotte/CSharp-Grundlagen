namespace Grundlagen.kleineProgramme {
    internal class Taschenrechner {
        public static void runTaschenrechner() {
            // Deklarieren und Initialisieren der Variablen.
            string operatoren;
            decimal endErgebnis = 0, zahl1, zahl2;
            bool isOperator;
            string plus = "+";
            string minus = "-";
            string mal = "*";
            string geteilt = "/";

            // Gebe folgenden Text in der Console aus...
            Console.WriteLine( "Geben Sie bitte die erste Zahl ein!" );
            // Initialisiere zahl1 mit Eingabe aus der Console
            zahl1 = Decimal.Parse( Console.ReadLine() );
            // Gebe folgenden Text in der Console aus...
            Console.WriteLine( "Geben sie bitte den Operator an! ( plus, minus, mal, geteilt )" );
            // Initialisiere console mit Eingabe aus der Console
            operatoren = Console.ReadLine();
            // Gebe folgenden Text in der Console aus...
            Console.WriteLine( "Geben Sie bitte die zweite Zahl ein!" );
            // Initialisiere zahl2 mit Eingabe aus der Console
            zahl2 = Decimal.Parse( Console.ReadLine() );

            // Wenn "bool" isOperator = (true) "operatoren.Contains(plus), Dann führe folgendes aus.
            if( isOperator = operatoren.Contains( plus ) ) {
                // Initialisiere endErgebnis mit (Methode)Addieren(zahl1, zahl2)
                endErgebnis = Addieren( zahl1, zahl2 );
            }
            // Wenn "bool" isOperator = (true) "operatoren.Contains(minus), Dann führe folgendes aus.
            if( isOperator = operatoren.Contains( minus ) ) {
                // Initialisiere endErgebnis mit (Methode)Subtrahieren(zahl1, zahl2)
                endErgebnis = Subtrahieren( zahl1, zahl2 );
            }
            // Wenn "bool" isOperator = (true) "operatoren.Contains(mal), Dann führe folgendes aus.
            if( isOperator = operatoren.Contains( mal ) ) {
                // Initialisiere endErgebnis mit (Methode)Multiplizieren(zahl1, zahl2)
                endErgebnis = Multiplizieren( zahl1, zahl2 );
            }
            // Wenn "bool" isOperator = (true) "operatoren.Contains(geteilt), Dann führe folgendes aus.
            if( isOperator = operatoren.Contains( geteilt ) ) {
                // Initialisiere endErgebnis mit (Methode)Devidieren(zahl1, zahl2)
                endErgebnis = Dividieren( zahl1, zahl2 );
            }

            // Lösche den gesamten Inhalt in der Console
            Console.Clear();
            // Gebe folgendes in der Console aus... Eingegebene Werte (zahl1, operator, zahl2) sowie das Endergebnis der Rechenaufgabe.
            Console.WriteLine( $" Ergebnis: {zahl1} {operatoren} {zahl2} = {endErgebnis}" );
        }

        // Methode Addieren(dezimal zahl1, decimal zahl2) erwartet die Eingaben aus den vorherigen If Anweisungen.
        static decimal Addieren( decimal zahl1, decimal zahl2 ) {
            // Führe folgende Rechenaufgabe aus und Initialisiere ergebnis.
            var ergebnis = zahl1 + zahl2;

            // Gebe die Variable ergebnis zurück.
            return ergebnis;
        }
        // Methode Subtrahieren(dezimal zahl1, decimal zahl2) erwartet die Eingaben aus den vorherigen If Anweisungen.
        static decimal Subtrahieren( decimal zahl1, decimal zahl2 ) {
            // Führe folgende Rechenaufgabe aus und Initialisiere ergebnis.
            var ergebnis = zahl1 - zahl2;

            // Gebe die Variable ergebnis zurück.
            return ergebnis;
        }

        // Methode Multiplizieren(dezimal zahl1, decimal zahl2) erwartet die Eingaben aus den vorherigen If Anweisungen.
        static decimal Multiplizieren( decimal zahl1, decimal zahl2 ) {
            // Führe folgende Rechenaufgabe aus und Initialisiere ergebnis.
            var ergebnis = zahl1 * zahl2;

            // Gebe die Variable ergebnis zurück.
            return ergebnis;
        }

        // Methode Dividieren(dezimal zahl1, decimal zahl2) erwartet die Eingaben aus den vorherigen If Anweisungen.
        static decimal Dividieren( decimal zahl1, decimal zahl2 ) {
            // Wenn zahl2 0 ist, dann führe folgendes aus
            if( zahl2 == 0 ) {
                // Mit return 0 übergebe ich ein ergebnis von 0 und beende die Methode.
                return 0;
            }

            // Führe folgende Rechenaufgabe aus und Initialisiere ergebnis.
            var ergebnis = zahl1 / zahl2;

            // Gebe die Variable ergebnis zurück.
            return ergebnis;
        }
    }
}