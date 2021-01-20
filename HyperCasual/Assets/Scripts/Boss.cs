using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    int health = 100;
    int damage = 50;
    
    public void TakeDamage(int dmg)
    {
        health -= dmg;
        if (health <= 0)
        {
            Destroy(gameObject, 0.5f);
            //Going to next level animation plays.
            //Goes to next level
        }
        
    }
    
}
