using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    [SerializeField] private IntVariable score;
    [SerializeField] private IntVariable highScore;

    private void Awake()
    {
        ResetScore();
    }

    public void ResetScore()
    {
        score.value = 0;
    }

    public void ManageScore(int amount)
    {
        score.value += amount;
        if (score.value > highScore.value)
        {
            highScore.value = score.value;
        }
    }
}
