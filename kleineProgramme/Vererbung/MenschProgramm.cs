namespace Grundlagen.kleineProgramme.Vererbung {
    internal class MenschProgramm {
        public static void runMenschProgramm() {
            MenschEigenschaften mensch1 = new MenschEigenschaften("Frank",47,183);

            Console.WriteLine( mensch1.Alter );
        }
    }
}
