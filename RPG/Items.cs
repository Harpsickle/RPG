using System;
using System.Linq;
using System.Collections.Generic;

class Items {
    
    public static List<string> merchantItemSell = new List<string>() {
    "Herb (Heals 5 HP): 25", 
    "Health Potion (Heals 15 HP): 75", 
    "Mana Potion (Restores 10 Mana): 50", 
    "Full Restore (Restores all HP and Mana): 300", 
    "Go Back"
    };

    public static List<string> merchantItems = new List<string>() {"Herb", "Health Potion", "Mana Potion", "Full Restore"};
    public static List<int> merchantItemValues =  new List<int>() {25, 75, 50, 300};
    public static List<int> itemStatValues = new List<int>() {5, 15, 10, 999};
    
}