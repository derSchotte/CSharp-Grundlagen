namespace Grundlagen.kleineProgramme;

internal class test {
    public static void runTest() {


        // Code goes here...

        int startJahr = 2001;
        int endJahr = 2002;

        DateOnly startDatum, aktuellesDatum, nächstesDatum;
        startDatum = new DateOnly( 2001, 01, 01 );

        for( int i = startJahr; i < endJahr; i++ ) {
            for( int t = 0; t < 365; t++ ) {
                if( t == 0 ) {
                    aktuellesDatum = startDatum;
                } else {
                    nächstesDatum = aktuellesDatum;
                    aktuellesDatum = nächstesDatum.AddDays( 1 );
                }

                string day = aktuellesDatum.Day.ToString();
                string month = aktuellesDatum.Month.ToString();
                string year = aktuellesDatum.Year.ToString();

                if( year.Contains( day ) && year.Contains( month ) ) {
                    Console.WriteLine( $"jahr: {year} beinhaltet: {day}.{month}" ); 
                }
            }
        }

        // End of code...

    }
}