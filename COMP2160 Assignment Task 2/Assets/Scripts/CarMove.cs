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
        if(transform.position.y < 2)
        {
            transform.position = new Vector3(transform.position.x, 2, transform.position.z);
            
        }
        float dx = Input.GetAxis(InputAxes.Horizontal);
        float dy = Input.GetAxis(InputAxes.Vertical);
        float r = Input.GetAxis(InputAxes.Respawn);
        if(r > 0)
        {
            transform.position = new Vector3(transform.position.x, 15, transform.position.z);
            transform.rotation = new Quaternion(0, 0, 0, 0);
        }
        if (Physics.Raycast(transform.position, -1 * transform.up, 3))
        {
            
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

}
