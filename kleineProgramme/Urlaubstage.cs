using System.Drawing;

namespace Grundlagen.kleineProgramme {
    internal class Urlaubstage {
        public static void RunUrlaubstage() {
            //  Für die Bestimmung des Urlaubsanspruchs des Antragsstellers ist ein Programm zu erstellen.
            //  Grundlage für die Berechnung des Urlaubsanspruchs bildet die Betriebsvereinbarung( siehe Anlage ).
            //  Erstellen Sie aufgrund der Betriebsvereinbarung ein Struktogramm, welches die richtige Höhe des
            //  Urlaubsanspruchs berechnet.

            //  Anlage Betriebsvereinbarung:
            //  Allen Beschäftigten stehen 26 Tage Urlaub zu.
            //  Minderjährige Beschäftigte erhalten 30 Tage Urlaub.
            //  Beschäftigte, die älter als 55 Jahre sind, erhalten 28 Tage Urlaub.
            //  Beschäftigte mit einer Behinderung ab 50 % erhalten zusätzlich 5 weitere Tage Urlaub.
            //  Beschäftigte mit einer Betriebszugehörigkeit von mehr als 10 Jahren erhalten 2 zusätzliche Tage Urlaub.

            //  Programmieren Sie dieses Programm mit den passenden Eingaben um die korrekte Antwort zu erhalten.

            int zugehörigkeit;
            int alter;
            int behinderung;
            int urlaub = 26;

            Console.WriteLine( "Wie alt sind sie?" );
            alter = int.Parse( Console.ReadLine() );

            Console.WriteLine( "Wie lange Arbeiten sie schon für uns ( in Jahren )" );
            zugehörigkeit = int.Parse( Console.ReadLine() );

            Console.WriteLine( "Haben sie eine Behinderung? Wenn ja welchen Grad in Prozent!" );
            behinderung = int.Parse( Console.ReadLine() );

            switch(alter, zugehörigkeit, behinderung) {
                case ( < 18, < 10, < 50 ): // Minderjährig, weniger als 10 jahre zugehörigkeit, weniger als 50% behinderung
                urlaub += 4;
                break;
                case ( > 55, < 10, < 50 ): // Älterer Mitarbeiter, weniger als 10 jahre zugehörigkeit, weniger als 50% behinderung
                urlaub += 7;
                break;
                case ( > 55, < 10, > 50 ): // Älterer Mitarbeiter, weniger als 10 jahre zugehörigkeit, mehr als 50% behinderung
                urlaub += 2;
                break;
                case ( >= 26, >= 10, < 50 ): // Mitarbeiter, mehr als 10 jahre zugehörigkeit, weniger als 50% behinderung
                urlaub += 2;
                break;
                case ( >= 26, >= 10, > 50 ): // Mitarbeiter, mehr als 10 jahre zugehörigkeit, mehr als 50% behinderung
                urlaub += 7;
                break;
                case ( >18, < 10, > 50 ): // Mitarbeiter, weniger als 10 jahre zugehörigkeit, mehr als 50% behinderung
                urlaub += 5;
                break;
            }

            Console.WriteLine( $"Sie haben {urlaub} Tage Urlaubsanspruch" );
        }
    }
}
