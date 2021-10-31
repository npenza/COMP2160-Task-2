using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Material Active;
    public Material Inactive;
    public bool Check;
    public bool Used = false;

    // Update is called once per frame
    void Update()
    {
        if (Check && !Used)
        {
            transform.GetComponent<Renderer>().material = Active;
        }
        else
        {
            transform.GetComponent<Renderer>().material = Inactive;
            Check = false;
        }
        
    }
}
