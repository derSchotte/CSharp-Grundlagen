namespace Grundlagen.kleineProgramme {
    internal class NewPassword {
        static int minLength = 4;

        public static void runNewPassword() {
            // erste Eingabe, zweite Eingabe
            // Prüfen erste Eingabe = zweite Eingabe
            // Prüfen auf Buchstaben, Zahlen und Sonderzeichen
            // Prüfen ob mindestens 4 Zeichen eingegeben wurden.
            // Bei falscheingabe, neuer Versuch...

            string eingabe1, eingabe2;
            bool same = false, big = false, numbers = false, chars = false, special = false;

            Console.WriteLine( "Bitte geben Sie ein Passwort ein!\n" +
                "\nEs sollte mindestens 4 Zeichen haben." +
                "\nAus einer Kombination von Buchstaben und Zahlen bestehen." +
                "\nSonderzeichen sind auch erlaubt!\n" );

            do {
                Console.Write( "1. Eingabe: " );
                eingabe1 = Console.ReadLine();
                Console.Write( "2. Eingabe: " );
                eingabe2 = Console.ReadLine();

                if( SamePassword( eingabe1, eingabe2 ) ) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine( "\nGeiles Password" );
                    Console.ForegroundColor = ConsoleColor.White;
                    same = true;
                } else {
                    Console.WriteLine( "Die eingegebenen Passwörter sind nicht Identisch" );
                }

                if( BigPassword( eingabe1, eingabe2 ) ) {
                    Console.WriteLine( "Die eingegebenen Passwörter sind größer oder gleich 4 Zeichen" );
                    big = true;
                } else {
                    Console.WriteLine( "Eines der eingegebenen Passwörter ist kleiner als 4 Zeichen" );
                }

                if( CheckForNumbers( eingabe1, eingabe2 ) ) {
                    Console.WriteLine( "Beide Passwörter enthalten Zahlen" );
                    numbers = true;
                } else {
                    Console.WriteLine( "Eines der Passwörter enthält keine Zahlen" );
                }

                if( CheckForChars( eingabe1, eingabe2 ) ) {
                    Console.WriteLine( "Beide Passwörter enthalten Buchstaben" );
                    chars = true;
                } else {
                    Console.WriteLine( "Eines der Passwörter enthält keine Buchstaben" );
                }

                if( CheckForSpecialChars( eingabe1, eingabe2 ) ) {
                    Console.WriteLine( "Beide Passwörter haben Sonderzeichen" );
                    special = true;
                } else {
                    Console.WriteLine( "Eines der Passwörter enthält keine Sonderzeichen" );
                }

            } while( !same || !big || !numbers || !chars || !special );


        }

        static bool SamePassword( string value, string value2 ) {
            string eingabe1 = value;
            string eingabe2 = value2;
            bool isSame = false;

            if( eingabe1.Equals( eingabe2 ) ) {
                isSame = true;
            }

            return isSame;
        }

        static bool BigPassword( string value, string value2 ) {
            string eingabe1 = value;
            string eingabe2 = value;
            bool isBigger = false;

            if( eingabe1.Length >= minLength && eingabe2.Length >= minLength ) {
                isBigger = true;
            }

            return isBigger;
        }

        static bool CheckForNumbers( string value, string value2 ) {
            string eingabe1 = value;
            string eingabe2 = value2;
            bool gotNumbers = false;

            bool hasNumbers = eingabe1.Any( c => char.IsDigit( c ) );
            bool hasNumbers2 = eingabe2.Any( c => char.IsDigit( c ) );

            if( hasNumbers && hasNumbers2 ) {
                gotNumbers = true;
            }

            return gotNumbers;
        }

        static bool CheckForChars( string value, string value2 ) {
            string eingabe1 = value;
            string eingabe2 = value2;
            bool hasChars = false;

            bool hasChars1 = eingabe1.Any(c => char.IsLetter(c));
            bool hasChars2 = eingabe2.Any(c => char.IsLetter(c));

            if( hasChars1 && hasChars2 ) {
                hasChars = true;
            }

            return hasChars;
        }

        static bool CheckForSpecialChars( string value, string value2 ) {
            string eingabe1 = value;
            string eingabe2 = value2;
            bool hasSpecialChars = false;

            bool hasChars1 = eingabe1.Any(c => ! char.IsLetterOrDigit(c));
            bool hasChars2 = eingabe2.Any(c => ! char.IsLetterOrDigit(c));

            if( hasChars1 && hasChars2 ) {
                hasSpecialChars = true;
            }

            return hasSpecialChars;
        }
    }
}
