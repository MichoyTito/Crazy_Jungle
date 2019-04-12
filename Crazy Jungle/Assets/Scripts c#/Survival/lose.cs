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

    private float coinsEarned;

    public void Dead()
    {
        losePanel.SetActive(true);
        gameManage.PauseLevel();
        finalScore.text = score.text;

        //Coins calculating
        float scoreFloat = float.Parse(finalScore.text);
        coinsEarned = scoreFloat * 0.01f;
        finalCoins.text = coinsEarned.ToString("F0");
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
