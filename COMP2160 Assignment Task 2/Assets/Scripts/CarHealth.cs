using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarHealth : MonoBehaviour
{

    public int CurHealth = 100;
    public GameObject Smoke;
    public UIManager UiScript;
    void Start()
    {
        Smoke = GameObject.Find("Smoke");
        Smoke.SetActive(false);
    }

    void Update()

    {
        if (CurHealth <= 20)
        {
            Smoke.SetActive(true);
        }
    }

    public void onCollision()
    {



        CurHealth = CurHealth - 5;
        UiScript.updateScrollbar();



        Debug.Log(CurHealth);
    }

    int UpdateHealth()
    {
        // CurHealth = curHealth;
        return CurHealth;
    }
}
