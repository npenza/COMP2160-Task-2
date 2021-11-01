using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CheckpointManager : MonoBehaviour
{
    public GameObject CheckPoint;
    // Start is called before the first frame update
    void Start()
    {
        CheckPoint.GetComponent<Checkpoint>().Check = true ;
        
    }
}
