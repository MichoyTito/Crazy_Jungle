using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class canvasMain : MonoBehaviour
{

    [SerializeField]
    private GameObject camera;
    [SerializeField]
    private GameObject loadScreen;
    [SerializeField]
    private GameObject areYouSure;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClickLevels()
    {
        FindObjectOfType<audioManager>().Play("Click");
        camera.GetComponent<Animator>().SetBool("onClickLevels", true);
    }
    public void onClickBack()
    {
        FindObjectOfType<audioManager>().Play("Click");
        camera.GetComponent<Animator>().SetBool("onClickLevels", false);
    }
    public void onClickLevelOne()
    {
        camera.GetComponent<Animator>().SetBool("loadScreen", true);
        loadScreen.SetActive(true);
        GameObject.Find("Background").GetComponent<AudioSource>().Stop();
        FindObjectOfType<audioManager>().Play("Click");
        Invoke("onLoadLevelOne", 3);
    }

    public void onClickSurvival()
    {
        FindObjectOfType<audioManager>().Play("Click");
        SceneManager.LoadScene("Survival");
    }
    public void onClickQuit()
    {
        FindObjectOfType<audioManager>().Play("Click");
        areYouSure.SetActive(true);
    }
    public void onClickYes()
    {
        Application.Quit();
        Application.Quit();
    }
    public void onClickNo()
    {
        areYouSure.SetActive(false);
    }

    public void onClickShop()
    {
        camera.GetComponent<Animator>().SetBool("loadScreen", true);
        loadScreen.SetActive(true);
        GameObject.Find("Background").GetComponent<AudioSource>().Stop();
        FindObjectOfType<audioManager>().Play("Click");
        Invoke("onLoadShop", 3);
    }
    public void onClickSettings()
    {
        FindObjectOfType<audioManager>().Play("Click");
    }



    private void onLoadLevelOne()
    {
        SceneManager.LoadScene("Level 1");
    }
    private void onLoadShop()
    {
        SceneManager.LoadScene("Shop");
    }
}
