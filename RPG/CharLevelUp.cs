using System;
using System.Collections.Generic;

class CharLevelUp {
    
        public static int statNumber = 0;
    
    
    public static void StatRoll() {
      
        Random roll = new Random ();
        int number = roll.Next (0, 3);
        statNumber = number;
    
  }
  
    public static void LevelUp() {
        
        Console.Clear();
        CharacterStats.charExperience -= CharacterStats.charMaxExp;
        CharacterStats.charMaxExp += 10;
        CharacterStats.charLevel++;
        CharacterStats.charDamage++;
        CharacterStats.charArmor++;
        CharLevelUp.StatRoll();
        CharacterStats.charMaxHealth += statNumber;
        CharLevelUp.StatRoll();
        CharacterStats.charMaxMana += statNumber;
        
        CharacterStats.charHealth = CharacterStats.charMaxHealth;
        CharacterStats.charMana = CharacterStats.charMaxMana;
        
        Console.WriteLine("You leveled up! You are now level " + CharacterStats.charLevel + " !");
        Console.WriteLine();
        Console.WriteLine("You grow stronger with improved stats: ");
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("HP: " + CharacterStats.charHealth + "/" + CharacterStats.charMaxHealth);
        Console.WriteLine("Mana: " + CharacterStats.charMana + "/" + CharacterStats.charMaxMana);
        Console.WriteLine("Attack damage: " + CharacterStats.charDamage);
        Console.WriteLine("Armor: " + CharacterStats.charArmor);
        
        while (Console.ReadKey ().Key != ConsoleKey.Enter)
      {
      }
    }
    
}