using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lose : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManage;

    [SerializeField]
    private GameObject losePanel;

    public void Dead()
    {
        losePanel.SetActive(true);
        gameManage.PauseLevel();
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
