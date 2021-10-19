using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    public Rigidbody rb;
    private bool Grounded;
    public float Velocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Grounded)
        {
            float dx = Input.GetAxis(InputAxes.Horizontal);
            float dy = Input.GetAxis(InputAxes.Vertical);
            if(dy == 1)
            {
                rb.AddForce(100 * transform.forward);   
            }

        }
        else
        {
            

        }
       

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Terrain")
        {
            Grounded = true;
        }

    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Terrain")
        {
            Grounded = false;
        }
    }

}
