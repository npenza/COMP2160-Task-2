using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float gameTime;
    public float displayTime;
    public Text UITime;
    public Scrollbar scrollbar;

    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        gameTime += Time.deltaTime;

        displayTime = Mathf.Round(gameTime * 100.0f) * 0.01f;

        UITime.text = displayTime.ToString();

    }

    public void updateScrollbar()
    {
        scrollbar.size -= 0.05F;
    }
}
