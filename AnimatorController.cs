using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    Animator animator;
    Object Enemy;
    EnemyFireSpell eFireSpell;
    

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        

        

    }

    public void OnTriggerEnter(Collider other)
    {
       

        if (other.gameObject.tag != "Enemy")
        {
            
            animator.SetTrigger("explosion");
            Invoke("yoket", 2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void yoket()
    {
        Destroy(gameObject);

    }
}
