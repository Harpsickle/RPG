using System;
using System.Linq;
using System.Collections.Generic;

class BattleTurns {

    public static void EnemyTurn() {
        
        Console.Clear();
	    Console.WriteLine($"The enemy attacks for {ListOfEnemies.newEnemy.attack} damage!");
	    CharacterStats.charHealth -= ListOfEnemies.newEnemy.attack;
	    while (Console.ReadKey ().Key != ConsoleKey.Enter)
      {
      }
    }
    
    public static void PlayerTurn() {
        
        Console.Clear();
	    Console.WriteLine ($"You attack for {CharacterStats.charDamage} damage!");
	    ListOfEnemies.newEnemy.health -= CharacterStats.charDamage;
	    while (Console.ReadKey ().Key != ConsoleKey.Enter)
      {
      }
    }
    
}