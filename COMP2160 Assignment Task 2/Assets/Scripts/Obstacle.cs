using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Start is called before the first frame update

    private int CollideCount;
    void OnTriggerEnter(Collider col)
    {

        if (CollideCount == 0)
        {
            GameObject Car = GameObject.Find("Car");
            CarHealth CarHealthScript = Car.GetComponent<CarHealth>();
            CarHealthScript.onCollision();
            CollideCount = 1;
        }


    }

    void OnTriggerExit(Collider col)
    {

        if (CollideCount == 1)
        {
            CollideCount = 0;
        }


    }


}
