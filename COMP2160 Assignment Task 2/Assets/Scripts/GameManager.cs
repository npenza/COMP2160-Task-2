using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameOverWinCanvas;
    public GameObject player;
    public CarHealth healthScript;
    public float timerTotalTime;
    public int checkpointsCollected;
    public Vector3 playerPosition;
    public int playerHealth;

    public bool gameState;

    void Start()
    {
        gameState = false;
        AnalyticsEvent.GameStart();
        healthScript = player.GetComponent<CarHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        playerHealth = healthScript.CurHealth;
        timerTotalTime += Time.deltaTime;
        playerPosition = player.transform.position;

        if (playerHealth <= 0)
        {
            GameOver();
        }

        if (checkpointsCollected == 11)
        {
            GameOver(true);
        }
    }

    public void checkPointCollected()
    {
        checkpointsCollected++;
        Analytics.CustomEvent("Checkpoint", new Dictionary<string, object>{
                {"Checkpoint Number", checkpointsCollected },
                {"Time Played", timerTotalTime },
                {"Player Health", playerHealth }
            });
    }

    public void GameOver(bool win)
    {
        playerPosition = player.transform.position;

        gameOverWinCanvas.SetActive(true);


        if (gameState == false)
        {
            AnalyticsEvent.GameOver();

            Analytics.CustomEvent("Game Win", new Dictionary<string, object>{
                {"Checkpoints Collected", checkpointsCollected },
                {"Time Played", timerTotalTime },
                {"Player Position", playerPosition }
            });
            gameState = true;
        }


        gameOverWinCanvas.SetActive(true);


    }

    public void GameOver()
    {
        Debug.Log("game over");

        if (gameState == false)
        {
            AnalyticsEvent.GameOver();

            Analytics.CustomEvent("Game Win", new Dictionary<string, object>{
                {"Checkpoints Collected", checkpointsCollected },
                {"Time Played", timerTotalTime },
                {"Player Position", playerPosition },
            });
            gameState = true;
        }





        // Display Lose UI
    }
}
