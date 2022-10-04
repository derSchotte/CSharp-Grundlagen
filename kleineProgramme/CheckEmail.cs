namespace Grundlagen.kleineProgramme {
    internal class CheckEmail {
        public static void runCheckEmail() {
            bool falseEmail = true;

            do {
                Console.WriteLine( "Geben Sie eine Email Adresse ein!" );
                Console.Write( "Email: " );
                string eingabe = Console.ReadLine();

                for( int i = 0; i < eingabe.Length; i++ ) {
                    if( eingabe[ i ] == '@' ) {
                        Console.WriteLine( "Es gibt ein @ Zeichen in ihrer Email" );
                        falseEmail = false;
                    }
                }
            } while( falseEmail == true );
        }
    }
}
