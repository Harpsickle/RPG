using System;
using System.Linq;
using System.Collections.Generic;

class ListOfEnemies {
    
    public static List<string> stage1Enemies = new List<string>() {
        "Level 1: Orc", "Level 1: Goblin", "Level 1: Wizard",  
        "Level 2: Orc", "Level 2: Goblin", "Level 2: Wizard", 
        "Level 3: Orc", "Level 3: Goblin", "Level 3: Wizard"
    }; 
    
    public static List<string> stage2Enemies = new List<string>() {
        "Level 4: Orc", "Level 4: Goblin", "Level 4: Wizard",  
        "Level 5: Orc", "Level 5: Goblin", "Level 5: Wizard", 
        "Level 6: Orc", "Level 6: Goblin", "Level 6: Wizard"
    };
    
    // Stats list order {"Health", "Max Health", "Attack Damage", "Armor", "Experience"}
    
    public static List<EnemyStats> stage1 = new List<EnemyStats> () {
    new EnemyStats(8, 8, 2, 1, 5),
    new EnemyStats(6, 6, 1, 0, 5),
    new EnemyStats(8, 8, 3, 0, 5),
    new EnemyStats(12, 12, 3, 1, 7),
    new EnemyStats(8, 8, 2, 1, 7),
    new EnemyStats(10, 10, 4, 0, 7),
    new EnemyStats(15, 15, 4, 2, 10),
    new EnemyStats(10, 10, 3, 1, 10),
    new EnemyStats(13, 13, 6, 0, 10)
    };
    
    public static List<EnemyStats> stage2 = new List<EnemyStats> () {
    new EnemyStats(18, 18, 6, 2, 12),
    new EnemyStats(13, 13, 4, 1, 12),
    new EnemyStats(15, 15, 8, 0, 12),
    new EnemyStats(22, 22, 7, 2, 14),
    new EnemyStats(15, 15, 5, 1, 14),
    new EnemyStats(19, 19, 10, 0, 14),
    new EnemyStats(25, 25, 9, 3, 15),
    new EnemyStats(18, 18, 6, 2, 15),
    new EnemyStats(22, 22, 12, 1, 15)
    };
    
    
    public static string enemyOpponent = "";
    public static EnemyStats newEnemy;
    
  public static void ActiveEncounter() {
    
        if (CharacterStats.charLevel <= 3) {
            
            Random enemyRoll = new Random ();
            int enemyNumber = enemyRoll.Next (stage1.Count);
            
            EnemyStats number = stage1[enemyNumber];
            newEnemy = number;
    
            Console.WriteLine("You encounter a " + stage1Enemies[enemyNumber] + "!");
            enemyOpponent = stage1Enemies[enemyNumber];
        }
        
            
        if (CharacterStats.charLevel > 3 && CharacterStats.charLevel < 7) {
            
            Random enemyRoll = new Random ();
            int enemyNumber = enemyRoll.Next (stage2.Count);
            
             Console.WriteLine("You encounter a " + stage2Enemies[enemyNumber] + "!");
             enemyOpponent = stage2Enemies[enemyNumber];
        }
        
        while (Console.ReadKey ().Key != ConsoleKey.Enter)
      {
      }
      Console.Clear();
        
    }
}