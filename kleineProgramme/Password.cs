namespace Grundlagen.kleineProgramme {
    internal class Password {
        public static void runPassword() {
            int password = 45789;
            int versuche = 3;
            int count = 1;
            int eingabe;
            bool isTrue = false;

            Console.WriteLine( "Bitte geben sie ein Password ein!" );

            while( !isTrue ) {
                eingabe = Int32.Parse( Console.ReadLine() );

                if( count < versuche ) {
                    if( eingabe != password ) {
                        Console.WriteLine( $"Sie haben das falsche Password eingegeben... \nSie haben noch {versuche - count} Versuche..." );

                        count++;
                    } else {
                        Console.WriteLine( "Password richtig" );
                        isTrue = true;
                    }
                } else {
                    Console.WriteLine( "Ihre Eingaben waren nicht Richtig... Bitte versuchen sie es morgen nochmal" );
                    isTrue = true;
                }

            }
        }
    }
}