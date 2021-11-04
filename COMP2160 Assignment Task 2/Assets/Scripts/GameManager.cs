using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject GameOverWinCanvas;
    public GameObject Player;
    public CarHealth HealthScript;
    public float TimerTotalTime;
    public int CheckpointsCollected;
    public Vector3 PlayerPosition;
    public int PlayerHealth;

    public bool GameState;

    void Start()
    {
        GameState = false;
        AnalyticsEvent.GameStart();
        HealthScript = Player.GetComponent<CarHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerHealth = HealthScript.CurHealth;
        TimerTotalTime += Time.deltaTime;
        PlayerPosition = Player.transform.position;

        if (PlayerHealth <= 0)
        {
            GameOver();
        }

        if (CheckpointsCollected == 11)
        {
            GameOver(true);
        }
    }

    public void checkPointCollected()
    {
        CheckpointsCollected++;
        Analytics.CustomEvent("Checkpoint", new Dictionary<string, object>{
                {"Checkpoint Number", CheckpointsCollected },
                {"Time Played", TimerTotalTime },
                {"Player Health", PlayerHealth }
            });
    }

    public void GameOver(bool win)
    {
        PlayerPosition = Player.transform.position;

        GameOverWinCanvas.SetActive(true);


        if (GameState == false)
        {
            AnalyticsEvent.GameOver();

            Analytics.CustomEvent("Game Win", new Dictionary<string, object>{
                {"Checkpoints Collected", CheckpointsCollected },
                {"Time Played", TimerTotalTime },
                {"Player Position", PlayerPosition }
            });
            GameState = true;
        }


        GameOverWinCanvas.SetActive(true);


    }

    public void GameOver()
    {
        Debug.Log("game over");

        if (GameState == false)
        {
            AnalyticsEvent.GameOver();

            Analytics.CustomEvent("Game Win", new Dictionary<string, object>{
                {"Checkpoints Collected", CheckpointsCollected },
                {"Time Played", TimerTotalTime },
                {"Player Position", PlayerPosition },
            });
            GameState = true;
        }





        // Display Lose UI
    }
}
