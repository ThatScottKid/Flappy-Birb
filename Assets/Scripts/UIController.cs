using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject upperUI;
    [SerializeField] private TextMeshProUGUI scoreCounter;      //Score counter at the top of UI

    [SerializeField] private GameObject introScreen;        //Play sutton screen
    [SerializeField] private GameObject restartScreen;      //Restart button screen

    [SerializeField] private IntVariable score;         //Actual score
    [SerializeField] private IntVariable highScore;     //Actual high score

    [SerializeField] private TextMeshProUGUI scoreText;     //Score text which appears on Restart menu
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
