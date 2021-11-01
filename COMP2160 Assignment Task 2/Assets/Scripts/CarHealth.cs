using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarHealth : MonoBehaviour
{

    public int CurHealth = 100;
    public GameObject smoke;
    void Start()
    {
        smoke = GameObject.Find("Smoke");
        smoke.SetActive(false);
    }

    void Update()

    {
        if (CurHealth <= 20)
        {
            smoke.SetActive(true);
        }
    }

    public void onCollision()
    {
        CurHealth = CurHealth - 5;
        Debug.Log(CurHealth);
    }

    int UpdateHealth()
    {
        // CurHealth = curHealth;
        return CurHealth;
    }
}
