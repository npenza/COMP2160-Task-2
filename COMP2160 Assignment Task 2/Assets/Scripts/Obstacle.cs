using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Start is called before the first frame update

    private int collideCount;
    void OnTriggerEnter(Collider col)
    {

        if (collideCount == 0)
        {
            GameObject car = GameObject.Find("Car");
            CarHealth carHealthScript = car.GetComponent<CarHealth>();
            carHealthScript.onCollision();
            collideCount = 1;
        }


    }

    void OnTriggerExit(Collider col)
    {

        if (collideCount == 1)
        {
            collideCount = 0;
        }


    }


}
