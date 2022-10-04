namespace Grundlagen.kleineProgramme {
    internal class BasisTier {
        public bool isAlive = true;
        public bool gesund = true;
        public bool leben = true;
    }

    internal class Hund: BasisTier {
        public string farbe = "Braun";
        public string name = "Scooby-Doo";
        public string rasse = "Deutsche Dogge";
    }
    internal class Tiere {
        public static void runDasTier() {
            Hund hund = new();

            var name = hund.name;
            string rasse = hund.rasse;
            var gesund = hund.gesund = true;
            var _gesund = "ja";
            var amLeben = hund.leben = false;
            var _AmLeben = "ja";

            if( gesund && amLeben ) {
                _gesund = "ja";
                _AmLeben = "ja";
            } else if( !gesund && amLeben ) {
                _gesund = "nein";
                _AmLeben = "ja, was man so am Leben nennen kann";
            } else if( gesund && !amLeben ) {
                _gesund = "gewesen, ja";
                _AmLeben = "nein";
            } else {
                _gesund = "nein";
                _AmLeben = "nein";
            }

            Console.Write( $"Name: {name}\nRasse: {rasse}\nGesund: {_gesund}\nAm Leben: {_AmLeben}" );
        }
    }
}
