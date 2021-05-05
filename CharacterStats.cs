using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterStats : MonoBehaviour
{
    HealthSystem healthSystem = new HealthSystem(100);
    public GameObject tryagainprefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(healthSystem.returnHealth() <= 0 && GameObject.FindGameObjectWithTag("UI") == null)
        {
            Instantiate(Resources.Load("Menus/TryAgain"), new Vector3(0, 0, 0), Quaternion.identity);
        }
    }

    public HealthSystem retCharHealth()
    {
        return healthSystem;
    }
    
}
