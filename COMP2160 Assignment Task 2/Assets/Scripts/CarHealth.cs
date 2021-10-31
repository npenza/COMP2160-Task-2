using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarHealth : MonoBehaviour
{

    public int CurHealth;
    private int curHealth = 100;
    void Start()
    {
        CurHealth = curHealth;
    }

    void Update()
    {
    }

    public void onCollision()
    {
        curHealth = curHealth - 5;
        Debug.Log(curHealth);
    }

    int UpdateHealth()
    {
        CurHealth = curHealth;
        return CurHealth;
    }
}
