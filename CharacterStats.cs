using System;
using System.Collections;
using System.Collections.Generic;

class CharacterStats {
    
    public static int charMaxHealth = 20;
    public static int charHealth = 20;
    public static int charDamage = 2;
    
    
    public void Stats () {
        
        Console.Clear();
        Console.WriteLine("Current HP: " + charHealth + "/" + charMaxHealth);
        Console.WriteLine();
        Console.WriteLine("Attack Damage: " + charDamage);
        Console.WriteLine();
        
        Console.WriteLine("Press enter to go back to home page.");
        while (Console.ReadKey ().Key != ConsoleKey.Enter)
      {
      }
      
      HomePage returnHome = new HomePage();
      returnHome.Home();
    }
  
}