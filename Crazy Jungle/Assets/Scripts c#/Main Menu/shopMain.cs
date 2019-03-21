using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class shopMain : MonoBehaviour
{

    [Header("game objects")]
    [SerializeField]
    private GameObject imageSlider;
    [SerializeField]
    private Text textTopBar;
    [SerializeField]
    private GameObject loadBar;
    [SerializeField]
    private GameObject cameraMain;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onClickHome()
    {
        FindObjectOfType<audioManager>().Play("Click");
        Invoke("changeScene", 2);
        cameraMain.GetComponent<Animator>().SetBool("load", true);
        loadBar.SetActive(true);
    }
    public void onClickUpgrades()
    {
        FindObjectOfType<audioManager>().Play("Click");
        imageSlider.GetComponent<Animator>().SetBool("Skin", false);
        textTopBar.text = "Upgrades";
    }
    public void onClickSkins()
    {
        FindObjectOfType<audioManager>().Play("Click");
        imageSlider.GetComponent<Animator>().SetBool("Skin", true);
        textTopBar.text = "Skins";
    }


    private void changeScene()
    {
        SceneManager.LoadScene("Main Menu");
    }
}

