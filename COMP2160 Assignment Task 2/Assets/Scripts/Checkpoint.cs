using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Material Active;
    public Material Inactive;
    public GameObject NextCheckpoint;
    public bool Check = false;

    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        Renderer Rend = GetComponent<Renderer>();
        if (Check == true)
        {
            Rend.material = Active;
        }
        else
        {
            Rend.material = Inactive;
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("car"))
        {
            Check = false;
            NextCheckpoint.GetComponent<Checkpoint>().Check = true;
        }
    }
}
