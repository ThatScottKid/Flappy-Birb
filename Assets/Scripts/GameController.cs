using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private FloatVariable obstSpeed;
    [SerializeField] private IntVariable score;


    private void Awake()
    {
        Application.targetFrameRate = 60;
        Pause();
    }

    public void bumpSpeed(float amount)
    {
        if(score.value % 10 == 0 && score.value != 0)
        {
            obstSpeed.value += amount;
            Debug.Log("BUMP");
        }
    }

    private void Pause()
    {
        Time.timeScale = 0;
    }

    private void Resume()
    {
        Time.timeScale = 1;
    }

    public void Play()
    {
        Resume();
    }

    public void GameOver()
    {
        Pause();
    }

    public void Quit()
    {
        Application.Quit();
    }
}
