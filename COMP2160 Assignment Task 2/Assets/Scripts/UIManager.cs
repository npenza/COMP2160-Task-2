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
    public Text cp3Time;
    public Text cp4Time;
    public Text cp5Time;
    public Text cp6Time;
    public Text cp7Time;
    public Text cp8Time;
    public Text cp9Time;
    public Text cp10Time;

    public GameObject cp1;
    public Checkpoint cp1Script;

    public GameObject cp2;
    public Checkpoint cp2Script;

    public GameObject cp3;
    public Checkpoint cp3Script;

    public GameObject cp4;
    public Checkpoint cp4Script;

    public GameObject cp5;
    public Checkpoint cp5Script;

    public GameObject cp6;
    public Checkpoint cp6Script;

    public GameObject cp7;
    public Checkpoint cp7Script;

    public GameObject cp8;
    public Checkpoint cp8Script;

    public GameObject cp9;
    public Checkpoint cp9Script;

    public GameObject cp10;
    public Checkpoint cp10Script;
    public Scrollbar scrollbar;

    void Start()
    {

        cp1Script = cp1.GetComponent<Checkpoint>();
        cp2Script = cp2.GetComponent<Checkpoint>();
        cp3Script = cp3.GetComponent<Checkpoint>();
        cp4Script = cp4.GetComponent<Checkpoint>();
        cp5Script = cp5.GetComponent<Checkpoint>();
        cp6Script = cp6.GetComponent<Checkpoint>();
        cp7Script = cp7.GetComponent<Checkpoint>();
        cp8Script = cp8.GetComponent<Checkpoint>();
        cp9Script = cp9.GetComponent<Checkpoint>();
        cp10Script = cp10.GetComponent<Checkpoint>();

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

        float cp3Disp = Mathf.Round(cp3Script.checkPointTime * 100.0f) * 0.01f;
        cp3Time.text = cp3Disp.ToString();

        float cp4Disp = Mathf.Round(cp4Script.checkPointTime * 100.0f) * 0.01f;
        cp4Time.text = cp4Disp.ToString();

        float cp5Disp = Mathf.Round(cp5Script.checkPointTime * 100.0f) * 0.01f;
        cp5Time.text = cp5Disp.ToString();

        float cp6Disp = Mathf.Round(cp6Script.checkPointTime * 100.0f) * 0.01f;
        cp6Time.text = cp6Disp.ToString();

        float cp7Disp = Mathf.Round(cp7Script.checkPointTime * 100.0f) * 0.01f;
        cp7Time.text = cp7Disp.ToString();

        float cp8Disp = Mathf.Round(cp8Script.checkPointTime * 100.0f) * 0.01f;
        cp8Time.text = cp8Disp.ToString();

        float cp9Disp = Mathf.Round(cp9Script.checkPointTime * 100.0f) * 0.01f;
        cp9Time.text = cp9Disp.ToString();

        float cp10Disp = Mathf.Round(cp10Script.checkPointTime * 100.0f) * 0.01f;
        cp10Time.text = cp10Disp.ToString();


    }

    public void updateScrollbar()
    {
        scrollbar.size -= 0.05F;
    }
}
