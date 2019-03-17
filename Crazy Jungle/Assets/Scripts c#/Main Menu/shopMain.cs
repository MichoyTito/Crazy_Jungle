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
    private Text  textTopBar;


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
        SceneManager.LoadScene("Main Menu");
    }
    public void onClickUpgrades()
    {
        imageSlider.GetComponent<Animator>().SetBool("Skin", false);
        textTopBar.text = "Upgrades";
    }
    public void onClickSkins()
    {
        imageSlider.GetComponent<Animator>().SetBool("Skin", true);
        textTopBar.text = "Skins";
    }

}
