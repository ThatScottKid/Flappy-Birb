using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject upperUI;
    [SerializeField] private TextMeshProUGUI scoreCounter;

    [SerializeField] private GameObject introScreen;
    [SerializeField] private GameObject restartScreen;

    [SerializeField] private IntVariable score;
    [SerializeField] private IntVariable highScore;

    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI highScoreText;


    private void Awake()
    {
        EnableIntroScreen();
        restartScreen.SetActive(false);
    }

    private void Update()
    {
        scoreCounter.text = score.value.ToString();
    }

    public void EnableIntroScreen()
    {
        introScreen.SetActive(true);
        restartScreen.SetActive(false);
    }

    public void EnableRestartScreen()
    {
        restartScreen.SetActive(true);
        scoreText.text = score.value.ToString();
        highScoreText.text = highScore.value.ToString();
    }

    public void DisableIntroScreen()
    {
        introScreen.SetActive(false);
    }
}
