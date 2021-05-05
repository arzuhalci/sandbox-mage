using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : MonoBehaviour
{
    MouseController ms;
    CharacterMovement cm;
    public float hiz;
    Rigidbody rb;
    Vector3 mousePos;
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        cm = GameObject.Find("Character").GetComponent<CharacterMovement>();
        ms = GetComponent<MouseController>();
        rb = this.GetComponent<Rigidbody>();
        //hiz = hiz + cm.gameObject.GetComponent<Rigidbody>().velocity.magnitude;
        Debug.Log(hiz);
        rb.AddForce(cm.mouseposdondur() * hiz);
        Debug.Log(cm.mouseposdondur());
        Invoke("destroyAfterCast",5);

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject != GameObject.Find("Character"))
        {
            collision.gameObject.GetComponent<Enemy>().retHealth().Damage(10);
        }
    }

    public Vector3 mouseposdondur()
    {
        mousePos = Input.mousePosition;
        mousePos = UnityEngine.Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, Camera.main.transform.position.y - transform.position.y));
        return mousePos;
    }

    public void destroyAfterCast()
    {
        Destroy(gameObject);
    }

}
