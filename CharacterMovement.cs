using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    Rigidbody rb;
    Vector3 mov;
    public float speed;
    Vector3 aimPos;
    Vector3 mousePos;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 aimPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mov.x = Input.GetAxisRaw("Horizontal");
        mov.z = Input.GetAxisRaw("Vertical");


    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + mov * speed * Time.fixedDeltaTime);
        transform.Rotate(aimPos);
        
    }

    public Vector3 mouseposdondur()
    {
        mousePos = Input.mousePosition;
        mousePos = UnityEngine.Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, Camera.main.transform.position.y - transform.position.y));
        mousePos = new Vector3(mousePos.x - transform.position.x, 0, mousePos.z - transform.position.z);
        mousePos = mousePos.normalized;
        return mousePos;
    }

}
