using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private FloatVariable obstSpeed, generationRate;
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
            generationRate.value = generationRate.value -= 0.1f;
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
        obstSpeed.value = 1f;
        generationRate.value = 1.1f;
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
