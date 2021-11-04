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
    public Text Cp1Time;
    public Text Cp2Time;
    public Text Cp3Time;
    public Text Cp4Time;
    public Text Cp5Time;
    public Text Cp6Time;
    public Text Cp7Time;
    public Text Cp8Time;
    public Text Cp9Time;
    public Text Cp10Time;

    public GameObject Cp1;
    public Checkpoint Cp1Script;

    public GameObject Cp2;
    public Checkpoint Cp2Script;

    public GameObject Cp3;
    public Checkpoint Cp3Script;

    public GameObject Cp4;
    public Checkpoint Cp4Script;

    public GameObject Cp5;
    public Checkpoint Cp5Script;

    public GameObject Cp6;
    public Checkpoint Cp6Script;

    public GameObject Cp7;
    public Checkpoint Cp7Script;

    public GameObject Cp8;
    public Checkpoint Cp8Script;

    public GameObject Cp9;
    public Checkpoint Cp9Script;

    public GameObject Cp10;
    public Checkpoint Cp10Script;

    public Scrollbar Scrollbar;

    void Start()
    {

        Cp1Script = Cp1.GetComponent<Checkpoint>();
        Cp2Script = Cp2.GetComponent<Checkpoint>();
        Cp3Script = Cp3.GetComponent<Checkpoint>();
        Cp4Script = Cp4.GetComponent<Checkpoint>();
        Cp5Script = Cp5.GetComponent<Checkpoint>();
        Cp6Script = Cp6.GetComponent<Checkpoint>();
        Cp7Script = Cp7.GetComponent<Checkpoint>();
        Cp8Script = Cp8.GetComponent<Checkpoint>();
        Cp9Script = Cp9.GetComponent<Checkpoint>();
        Cp10Script = Cp10.GetComponent<Checkpoint>();

    }

    // Update is called once per frame
    void Update()
    {
        gameTime += Time.deltaTime;

        displayTime = Mathf.Round(gameTime * 100.0f) * 0.01f;

        UITime.text = displayTime.ToString();

        float cp1Disp = Mathf.Round(Cp1Script.CheckPointTime * 100.0f) * 0.01f;
        Cp1Time.text = cp1Disp.ToString();

        float cp2Disp = Mathf.Round(Cp2Script.CheckPointTime * 100.0f) * 0.01f;
        Cp2Time.text = cp2Disp.ToString();

        float cp3Disp = Mathf.Round(Cp3Script.CheckPointTime * 100.0f) * 0.01f;
        Cp3Time.text = cp3Disp.ToString();

        float cp4Disp = Mathf.Round(Cp4Script.CheckPointTime * 100.0f) * 0.01f;
        Cp4Time.text = cp4Disp.ToString();

        float cp5Disp = Mathf.Round(Cp5Script.CheckPointTime * 100.0f) * 0.01f;
        Cp5Time.text = cp5Disp.ToString();

        float cp6Disp = Mathf.Round(Cp6Script.CheckPointTime * 100.0f) * 0.01f;
        Cp6Time.text = cp6Disp.ToString();

        float cp7Disp = Mathf.Round(Cp7Script.CheckPointTime * 100.0f) * 0.01f;
        Cp7Time.text = cp7Disp.ToString();

        float cp8Disp = Mathf.Round(Cp8Script.CheckPointTime * 100.0f) * 0.01f;
        Cp8Time.text = cp8Disp.ToString();

        float cp9Disp = Mathf.Round(Cp9Script.CheckPointTime * 100.0f) * 0.01f;
        Cp9Time.text = cp9Disp.ToString();

        float cp10Disp = Mathf.Round(Cp10Script.CheckPointTime * 100.0f) * 0.01f;
        Cp10Time.text = cp10Disp.ToString();


    }

    public void updateScrollbar()
    {
        Scrollbar.size -= 0.05F;
    }
}
