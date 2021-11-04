using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Material Active;
    public Material Inactive;
    public float CheckPointTime;
    public GameManager GManager;
    public GameObject NextCheckpoint;
    public bool Check = false;
    public float ActiveTime;

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
            CheckPointTime = GManager.GetComponent<GameManager>().TimerTotalTime;
        }
    }
}
