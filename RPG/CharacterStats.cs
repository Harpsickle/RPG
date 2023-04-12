using System;
using System.Collections;
using System.Collections.Generic;

class CharacterStats {
    
    public static int charMaxHealth = 20;
    public static int charHealth = 20;
    public static int charDamage = 2;
    public static int charArmor = 0;
    
    public void Stats () {
        
        while (true) {
        Console.Clear();
        Console.WriteLine("Current HP: " + charHealth + "/" + charMaxHealth);
        Console.WriteLine();
        Console.WriteLine("Attack Damage: " + charDamage);
        Console.WriteLine();
        Console.WriteLine("Amor: " + charArmor);
        Console.WriteLine();
        
        Console.WriteLine("Press backspace to return.");
        
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.Backspace) {
            break;
            }
            if (keyInfo.Key == ConsoleKey.Enter) {
            continue;
            }
        }
      }
    }
  
