using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    public Rigidbody rb;
    public float Velocity;
    public float Rotation;
    private bool Grounded;
    public float MaxSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Grounded)
        {
            float dx = Input.GetAxis(InputAxes.Horizontal);
            float dy = Input.GetAxis(InputAxes.Vertical);
            if (dy != 0)
            {
                if (Velocity < MaxSpeed && Velocity > -MaxSpeed)
                {
                    Velocity += dy;
                }

            }
            else
            {
                if (Velocity < 0)
                {
                    Velocity += 1;
                }
                if (Velocity > 0)
                {
                    Velocity -= 1;
                }
            }


            if (dy > 0)
            {
                float angle = dx * Rotation * Time.deltaTime;
                transform.Rotate(new Vector3(0, angle, 0));
            }
            if (dy < 0)
            {
                float angle = dx * -Rotation * Time.deltaTime;
                transform.Rotate(new Vector3(0, angle, 0));
            }

        }
        else
        {
            


        }
        
        rb.transform.Translate(Vector3.forward * Velocity * Time.deltaTime);

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
