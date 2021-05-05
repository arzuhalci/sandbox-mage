using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 mousePos;
    public Ray ray;
    public float y;
    public float x;
    public Vector3 eulerDegree;
    private Transform aimTransform;
    private Quaternion targetRotation;
    public float rotationSpeed = 450;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    private void Awake()
    {
        aimTransform = GameObject.Find("Character").transform;
        
    }
    // Update is called once per frame
    void Update()
    {
        ControlMouse();

    }

    public void ControlMouse()
    {

        mousePos = Input.mousePosition;
        mousePos = UnityEngine.Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, Camera.main.transform.position.y - transform.position.y));
        targetRotation = Quaternion.LookRotation(mousePos - new Vector3(rb.transform.position.x, 0, rb.transform.position.z));
        rb.transform.eulerAngles = Vector3.up * Mathf.MoveTowardsAngle(rb.transform.eulerAngles.y,targetRotation.eulerAngles.y,rotationSpeed * Time.deltaTime );
        


    }



    

    public bool MouseTiklandi()
    {
        if (Input.GetMouseButtonDown(1) == false)
        {
            return false;
        }
        return true;       
        
    }

    float AngleBetweenTwoPoints(Vector3 a, Vector3 b)
    {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }

}
