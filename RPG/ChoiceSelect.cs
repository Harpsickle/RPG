using System;
using System.Collections;
using System.Collections.Generic;

class ChoiceSelect {
    
    public static int overallIndex = 0;
    
    
    public static void Selection(List<string> select, int index, string questions) {
      
      while (true) {    
          Console.Clear();
          Console.WriteLine(questions);
          Console.WriteLine();
     
      for (int i = 0; i < select.Count; i++) {
          
	    if (i == index)
	      {
		Console.Write("> ");
	      }
	    Console.WriteLine (select[i]);
	  }    
        
        
      var keyInfo1 = Console.ReadKey (true);
	  switch (keyInfo1.Key)
	  {
	  case ConsoleKey.UpArrow:
	    index = (index == 0) ? select.Count - 1 : index - 1;
	    break;
	  case ConsoleKey.DownArrow:
	    index = (index == select.Count - 1) ? 0 : index + 1;
	    break;
	  case ConsoleKey.Enter:
	    overallIndex = index;
	    return;
	  default:
	    break;
	  }
    }
    }
}