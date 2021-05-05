using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    //General variables
    Rigidbody rb;


    //Enemy spell casting AI section
    Quaternion targetRotation;
    public float rotationSpeed = 450;
    public GameObject spellPrefab;


    //Enemy movement AI section
    public float speed;
    public float stoppingDistance;
    public float retreatDistance;

    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Character").transform;
        rb = gameObject.GetComponent<Rigidbody>();

        //Spell casting AI section
        InvokeRepeating("enemyCastSpell",1,3);
    }

    // Update is called once per frame
    void Update()
    {
        //Enemy movement AI section
        if (Vector3.Distance(transform.position, player.position) > stoppingDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
        else if (Vector3.Distance(transform.position, player.position) < stoppingDistance && Vector3.Distance(transform.position, player.position) > retreatDistance)
        {
            transform.position = this.transform.position;

        }
        else if (Vector3.Distance(transform.position, player.position) < retreatDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
        }
        //--------------------------------------------------------------

        //Enemy spell casting AI section

        targetRotation = Quaternion.LookRotation(player.position - new Vector3(rb.transform.position.x, 0, rb.transform.position.z));
        rb.transform.eulerAngles = Vector3.up * Mathf.MoveTowardsAngle(rb.transform.eulerAngles.y, targetRotation.eulerAngles.y, rotationSpeed * Time.deltaTime);

        //--------------------------------------------------------------

    }

    public void enemyCastSpell()
    {
        Instantiate(spellPrefab, rb.position, Quaternion.identity);
    }

}
