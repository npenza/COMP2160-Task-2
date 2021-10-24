using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPivot : MonoBehaviour
{
    public GameObject Car;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Car.transform.position;
        transform.rotation = Quaternion.Lerp(transform.rotation, Car.transform.rotation, Time.time * Speed);
    }
}
