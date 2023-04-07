using System;
using System.Collections;
using System.Collections.Generic;

class CharacterInventory {
    
     public static int charGold = 0;
     public static List<string> charItems = new List<string>();
     
  public void PrintCharInventory() { 
      
    Console.Clear();
    Console.WriteLine("Current Gold: " + charGold);
    Console.WriteLine();
    Console.WriteLine("All items in your inventory: ");
    

    foreach (string i in CharacterInventory.charItems) {
          Console.WriteLine(i);
      }
      Console.WriteLine();
      Console.WriteLine("Press Enter to go back home.");
      
    while (Console.ReadKey ().Key != ConsoleKey.Enter)
      {
      }
      HomePage goBack = new HomePage();
      goBack.Home();
      
  }
}