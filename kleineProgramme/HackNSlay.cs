namespace Grundlagen.kleineProgramme {
    internal class HackNSlay {
        public static void runHackNSlay() {
            int playerHp = 40;
            int enemyHp = 40;

            int playerAttack = 5;
            int enemyAttack = 5;

            int healAmount = 3;

            Random rand = new Random();

            while( playerHp > 0 && enemyHp > 0 ) {
                // Player turn
                Console.WriteLine( " --- Player turn --- " );
                Console.WriteLine( $"PlayerHp: {playerHp} - EnemyHp: {enemyHp}" );
                Console.WriteLine( "Enter 'a' to attack or 'h' to heal" );

                string choice = Console.ReadLine();

                switch( choice ) {
                    case "a":
                    enemyHp -= playerAttack;
                    Console.WriteLine( $"Player attack enemy and deals {playerAttack} damage!" );
                    break;
                    case "h":
                    playerHp += healAmount;
                    Console.WriteLine( $"Player restores {healAmount} health points!" );
                    break;
                }

                // Enemy turn
                Console.WriteLine( " --- Enemy turn --- " );
                Console.WriteLine( $"PlayerHp: {playerHp} - EnemyHp: {enemyHp}" );
                int enemyChoise = rand.Next(0,2);

                switch( enemyChoise ) {
                    case 0:
                    playerHp -= enemyAttack;
                    Console.WriteLine( $"Enemy attacks and deals {enemyAttack} damage!" );
                    break;
                    case 1:
                    enemyHp += healAmount;
                    Console.WriteLine( $"Enemy restores {healAmount} health points!" );
                    break;
                }
            }

            if( playerHp > 0 && enemyHp <= 0 ) {
                Console.WriteLine( "Congratz, you win!" );
            } else {
                Console.WriteLine( "Game Over" );
            }
        }
    }
}
