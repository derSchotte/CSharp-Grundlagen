namespace Grundlagen.kleineProgramme {
    internal class OrderArray {
        public static void runOrderArray() {
            // Initialisiere string array "eingaben" und Deklariere ein neues leeres string array als Inhalt.
            string[] eingaben = new string[] {};

            // for ( Initialisiere I und Deklariere mit 0; Frage "IST" i kleiner "<" als 3; "WENN" i kleiner 3 dann i = i + 1 zusammengefasst "i++";
            for( int i = 0; i < 3; i++ ) {
                // Gebe in der Console folgenden Text aus...
                Console.WriteLine( "Ich erwarte eine Eingabe:" );
                //Initialisiere var "eingabe" und Deklariere mit der Eingabe aus der Console
                var eingabe = Console.ReadLine();

                // IF-ANWEISUNG
                // Wenn "eingabe" ist nicht gleich null, dann führe folgendes aus...
                if( eingabe != null ) {
                    // Nehme eingaben und führe folgendes aus...
                    // eingaben.Concat() - füge die eingabe nacheinander zusammen...
                    // new[] {<inhalt>} ist dazu gedacht um die Eingaben von einander zu trennen, damit diese in das Array eingaben eingefügt werden können.
                    // Ohne diese würde nur ein Wert im Array stehen mit dem eingegebenen string an Platz 0
                    // .ToArray(); - Übergebe die noten in das Array.
                    eingaben = eingaben.Concat( new[] { eingabe } ).ToArray();
                }
            }

            // for ( Initialisiere I und Deklariere mit eingaben.length - 1; Frage "IST" i größer gleich ">=" als 0; "WENN" i größer gleich 0 dann i = i - 1 zusammengefasst "i--";
            for( int i = eingaben.Length - 1; i >= 0; i-- ) {
                // Gebe folgendes in der Console aus...
                Console.WriteLine( $"I: {i}, eingaben: {eingaben[ i ]}" );
            }
        }
    }
}