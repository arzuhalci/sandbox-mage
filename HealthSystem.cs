using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem
{

    private int health;

    public HealthSystem(int health)
    {
        this.health = health;
    }

    public void Damage(int damageAmount)
    {
        health -= damageAmount;
    }

    public float returnHealth()
    {
        return health;
    }
}
