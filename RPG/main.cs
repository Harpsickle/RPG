using System;
using System.Collections;
using System.Collections.Generic;

class RPG {
    
  public static void Main () {

    Title home = new Title();
    home.GameTitle();
    
  }
  
  public void Goodbye() {
    Console.WriteLine("Thank you for Playing");
    Console.WriteLine(); 
    while (Console.ReadKey ().Key != ConsoleKey.Enter)
      {
      }
    Environment.Exit(0);
        
    }
}