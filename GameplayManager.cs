using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject winPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");

        if (enemies.Length == 0 && GameObject.FindGameObjectWithTag("UI") == null)
        {
            Instantiate(Resources.Load("Menus/You Win!"), new Vector3(0, 0, 0), Quaternion.identity);
        }
    }

   public void Restart()
    {
        SceneManager.LoadScene("Sample Scene");
    }

}
