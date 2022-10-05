namespace Grundlagen.kleineProgramme {
    internal class LottoGenerator {
        static Random rand = new ();
        static int index, eingabe, gezogeneZahl, bereitsGezogen = -1;
        static int[] lottoArray = new int[49];
        static int[] ziehung = new int[6];
        static int[] lottoSchein = new int[6];
        public static void runLottoGenerator() {
            UserEingabe();

            // Array mit Lottozahlen generieren
            GenerateLottoZahlen();

            // Array mit der Ziehung erstellen
            GenerateZiehung();

            for( int i = 0; i < lottoSchein.Length; i++ ) {
                bool win = Array.Exists(ziehung, e => e == lottoSchein[i]);

                if( win ) {
                    Console.WriteLine( $"Sie haben die Zahl: {lottoSchein[ i ]} richtig!" );
                }
            }


            foreach( var item in ziehung ) {
                Console.Write( "\nZiehung: " );
                Console.Write( $" {item}" );
            }
        }

        static void UserEingabe() {
            Console.WriteLine( "Bitte geben sie ihren Lottotipp ab!" );

            for( int i = 0; i < lottoSchein.Length; i++ ) {
                if( i == 0 ) {
                    Console.Write( "\nEingabe: " );
                }

                bool falscheEingabe = false;

                do {
                    eingabe = Int32.Parse( Console.ReadLine() );

                    falscheEingabe = Array.Exists( lottoSchein, e => e == eingabe );

                    if( falscheEingabe ) {
                        Console.Write( "\nDer Tipp ist schon Vorhanden!\nEingabe: " );
                        eingabe = Int32.Parse( Console.ReadLine() );
                    }

                } while( eingabe > 49 );


                lottoSchein[ i ] = eingabe;
            }

            Console.Write( "Getippt: " );

            foreach( var item in lottoSchein ) {
                Console.Write( $"'{item}' " );
            }
            Console.WriteLine( "\n" );
        }

        static Array GenerateLottoZahlen() {
            for( int i = 0; i < lottoArray.Length; i++ ) {
                lottoArray[ i ] = i + 1;
            }

            return lottoArray;
        }

        static Array GenerateZiehung() {
            for( int i = 0; i < ziehung.Length; i++ ) {
                do {
                    index = GenerateRandom();
                    gezogeneZahl = lottoArray[ index ];

                } while( gezogeneZahl == bereitsGezogen );

                lottoArray[ index ] = bereitsGezogen;
                ziehung[ i ] = gezogeneZahl;
            }

            return ziehung;
        }

        static int GenerateRandom() {
            return rand.Next( 1, lottoArray.Length );
        }
    }
}
