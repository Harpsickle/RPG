using System;
using System.Linq;
using System.Collections.Generic;

class EnemyStats {
    
    public int health;
    public int maxHealth;
    public int attack;
    public int armor;
    public int exp;

  public EnemyStats (int hp, int maxhp, int damage, int defence, int xp) {
    
    health = hp;
    maxHealth = maxhp;
    attack = damage;
    armor = defence;
    exp = xp;
  }
}
 

