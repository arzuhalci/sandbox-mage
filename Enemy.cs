using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    HealthSystem healthSystem = new HealthSystem(100);

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(healthSystem.returnHealth() <= 0)
        {
            Destroy(gameObject);
        }
    }

    public HealthSystem retHealth()
    {
        return healthSystem;
    }
}
