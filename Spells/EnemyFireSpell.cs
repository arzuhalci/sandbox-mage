using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFireSpell : MonoBehaviour
{
    Transform player;
    Rigidbody rb;
    public float hiz;
    
    Vector3 targetPos;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Character").GetComponent<Transform>();
        rb = gameObject.GetComponent<Rigidbody>();
        targetPos = player.position - rb.position;
        Debug.Log(player.position.normalized * 100);
        rb.AddForce(targetPos.normalized * hiz);
        Invoke("deleteThis", 5);
        
    }


    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        other.gameObject.GetComponent<CharacterStats>().retCharHealth().Damage(10);
        Debug.Log(other.gameObject.GetComponent<CharacterStats>().retCharHealth().returnHealth());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void deleteThis()
    {
        Destroy(gameObject);
    }
}
