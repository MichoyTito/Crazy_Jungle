using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class lose : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManage;

    [Header("Objects")]
    [SerializeField]
    private GameObject losePanel;

    [Header("Texts")]
    [SerializeField]
    private Text score;
    [SerializeField]
    private Text finalScore;
    [SerializeField]
    private Text finalCoins;
    [SerializeField]
    private Text bestScore;

    private float coinsEarned;


    private void Start()
    {
        if(PlayerPrefs.GetFloat("Coins") == 0)
        {
            PlayerPrefs.SetFloat("Coins", 0);
        }
        if(PlayerPrefs.GetFloat("bestScore") == 0)
        {
            PlayerPrefs.SetFloat("bestScore", 0);
        }
    }

    public void Dead()
    {
        losePanel.SetActive(true);
        gameManage.PauseLevel();
        finalScore.text = score.text;

        //Coins calculating
        float scoreFloat = float.Parse(finalScore.text);
        coinsEarned = scoreFloat * 0.01f;
        finalCoins.text = coinsEarned.ToString("F0");

        PlayerPrefs.SetFloat("Coins", PlayerPrefs.GetFloat("Coins") + coinsEarned);

        if(scoreFloat > PlayerPrefs.GetFloat("bestScore"))
        {
            PlayerPrefs.SetFloat("bestScore", scoreFloat);
        }
        bestScore.text = PlayerPrefs.GetFloat("bestScore").ToString();

    }

    public void onClickMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void onClickResume()
    {
        losePanel.SetActive(false);
    }
}
