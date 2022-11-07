namespace Grundlagen.kleineProgramme.Vererbung {
    internal class MenschEigenschaften {
        string name;
        int alter;
        int groesse;

        public MenschEigenschaften( string name, int alter, int groesse ) {
            Name = name;
            Alter = alter;
            Groesse = groesse;
        }

        public string Name { get => name; set => name = value; }
        public int Alter { get => alter; set => alter = value; }
        public int Groesse { get => groesse; set => groesse =  value ; }
    }
}
