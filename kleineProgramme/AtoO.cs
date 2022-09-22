namespace Grundlagen.kleineProgramme {
    internal class AtoO {
        public static void runAtoO() {
            // Initialisiere eingabe und Deklariere mit einem leeren string ""
            string eingabe = "";

            // Gebe den Text in der Console aus mit Console.WriteLine
            Console.WriteLine( "Geben Sie einen Satz ein" );

            // Deklariere eingabe mit Console.ReadLine() "Eingabe des Benutzers"
            eingabe = Console.ReadLine();

            // Nehme die Variable eingabe und erstetze alle kleinen a mit einem o, per Replace Funktion
            eingabe = eingabe.Replace( "a", "o" );
            // Nehme die Variable eingabe und erstetze alle großen A mit einem O, per Replace Funktion
            eingabe = eingabe.Replace( "A", "O" );

            // Gebe die variable eingabe in der Console aus.
            Console.WriteLine( eingabe );
        }
    }
}
