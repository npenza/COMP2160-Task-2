using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Start is called before the first frame update


    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player") == true)
        {
            GameObject car = GameObject.Find("Car");
            CarHealth carHealthScript = car.GetComponent<CarHealth>();
            // playerScript.coinsCollectedp2++;
            carHealthScript.onCollision();
            // Destroy(transform.gameObject);
        }
    }


}
