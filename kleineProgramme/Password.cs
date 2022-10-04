namespace Grundlagen.kleineProgramme
{
    public class Password
    {
        public static void runPassword()
        {
            int password = 54948;
            bool isTrue = false;
            int eingabe;


            while (!isTrue)
            {
                eingabe = Int32.Parse(Console.ReadLine());
                Console.Write("Bitte geben sie das Password ein: ");
             
                if (eingabe != password)
                {
                    Console.WriteLine("Das Password war nicht richtig");
                }
                else
                {
                    Console.WriteLine("Die eingabe war Richtig");
                }

                isTrue = true;
            }
            Console.ReadKey();
        }
    }
}