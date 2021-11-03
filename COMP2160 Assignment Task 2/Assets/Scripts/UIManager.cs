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
    public Text cp1Time;
    public Text cp2Time;

    public GameObject cp1;
    public Checkpoint cp1Script;

    public GameObject cp2;
    public Checkpoint cp2Script;
    public Scrollbar scrollbar;

    void Start()
    {

        cp1Script = cp1.GetComponent<Checkpoint>();
        cp2Script = cp2.GetComponent<Checkpoint>();

    }

    // Update is called once per frame
    void Update()
    {
        gameTime += Time.deltaTime;

        displayTime = Mathf.Round(gameTime * 100.0f) * 0.01f;

        UITime.text = displayTime.ToString();

        float cp1Disp = Mathf.Round(cp1Script.checkPointTime * 100.0f) * 0.01f;
        cp1Time.text = cp1Disp.ToString();

        float cp2Disp = Mathf.Round(cp2Script.checkPointTime * 100.0f) * 0.01f;
        cp2Time.text = cp2Disp.ToString();


    }

    public void updateScrollbar()
    {
        scrollbar.size -= 0.05F;
    }
}
