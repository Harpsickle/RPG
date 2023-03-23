using System;
using System.Collections;
using System.Collections.Generic;

class RPG {
    
  public static void Main () {

    Console.WriteLine ("Welcome to the game. Press Enter to get started!");
    while (Console.ReadKey ().Key != ConsoleKey.Enter)
      {
      }
    
    
    CharacterMovement move = new CharacterMovement ();
    move.CharacterWalk ();
    
  }
}