using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Start is called before the first frame update


    void OnTriggerEnter(Collider col)
    {
        Debug.Log("col");
        if (col.gameObject.CompareTag("car") == true)
        {
            GameObject car = GameObject.Find("Car");
            CarHealth carHealthScript = car.GetComponent<CarHealth>();
            carHealthScript.onCollision();
        }
    }


}
