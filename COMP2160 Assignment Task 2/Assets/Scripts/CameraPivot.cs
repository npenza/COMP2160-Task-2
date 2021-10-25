using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPivot : MonoBehaviour
{
    public GameObject Car;
    private float CarVelocity;
    public float TurnSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CarVelocity = Car.GetComponent<CarMove>().Velocity;
        transform.position = Car.transform.position;
        transform.rotation = Quaternion.Lerp(transform.rotation, Car.transform.rotation, Time.time * TurnSpeed);
        transform.localPosition = transform.localPosition - (transform.forward * CarVelocity / 10);
    }
}
