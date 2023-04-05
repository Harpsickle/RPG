using System;
using System.Collections;
using System.Collections.Generic;

class CharacterStats {
    
    public void Stats () {
        Console.WriteLine("Nothing to see here. Press enter to go back to home page.");
        while (Console.ReadKey ().Key != ConsoleKey.Enter)
      {
      }
      
      HomePage returnHome = new HomePage();
      returnHome.Home();
    }
  
}