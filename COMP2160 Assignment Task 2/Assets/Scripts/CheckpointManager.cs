using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    
    public GameObject Checkpoint1;
    public GameObject Checkpoint2;
    public GameObject Checkpoint3;
    public GameObject Checkpoint4;
    private bool Check1;
    private bool Check2;
    private bool Check3;
    private bool Check4;
    private bool Used1;
    private bool Used2;
    private bool Used3;
    private bool Used4;

    // Start is called before the first frame update
    void Start()
    {
        Check1 = Checkpoint1.GetComponent<Checkpoint>().Check;
        Check2 = Checkpoint2.GetComponent<Checkpoint>().Check;
        Check3 = Checkpoint3.GetComponent<Checkpoint>().Check;
        Check4 = Checkpoint4.GetComponent<Checkpoint>().Check;
        Used1 = Checkpoint1.GetComponent<Checkpoint>().Used;
        Used1 = Checkpoint2.GetComponent<Checkpoint>().Used;
        Used1 = Checkpoint3.GetComponent<Checkpoint>().Used;
        Used1 = Checkpoint4.GetComponent<Checkpoint>().Used;
        Check1 = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (!Check1 && Used1)
        {
            Check2 = true;
        }
        if (!Check2 && Used2)
        {
            Check3 = true;
        }
        if (!Check3 && Used3)
        {
            Check4 = true;
        }
        
    }
}
