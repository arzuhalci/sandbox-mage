using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellManager : MonoBehaviour
{
    bool firespell;
    Rigidbody rb;
    public GameObject fireprojectilePrefab;
    Vector3 spawnpos;
    bool slot1;
    bool slot2;
    bool slot3;

    // Start is called before the first frame update
    void Start()
    {

        rb = GameObject.Find("Character").GetComponent<Rigidbody>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            slot1 = true;
            slot2 = false;
            slot3 = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            slot1 = false;
            slot2 = true;
            slot3 = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            slot1 = false;
            slot2 = false;
            slot3 = true;
        }

        if(Input.GetMouseButtonDown(0))
        { 
        //if (slot1)
        //{
            spawnpos = new Vector3(rb.transform.position.x, rb.transform.position.y, rb.transform.position.z);
            Instantiate(fireprojectilePrefab, spawnpos, Quaternion.identity);
        //}

        /*if (slot2)
        {
            Debug.Log("slot 2");
        }*/

        /*if (slot3)
        {
            Debug.Log("slot3");
        }*/
    }

        /*if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            firespell = true;
        }
        if (firespell)
        {
            if (Input.GetMouseButtonDown(1))
            {
                spawnpos = new Vector3(rb.transform.position.x, rb.transform.position.y, rb.transform.position.z);
                Instantiate(fireprojectilePrefab, spawnpos, Quaternion.identity);
            }
        }*/
    }
}
