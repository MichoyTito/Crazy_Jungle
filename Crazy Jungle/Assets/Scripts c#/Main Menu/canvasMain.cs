using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class canvasMain : MonoBehaviour
{
    //[Header("Canvas Items")]
    //[SerializeField]
    //private GameObject Levels;
    // [SerializeField]
    //private GameObject Survival;
    //[SerializeField]
    // private GameObject Quit;
    // [SerializeField]
    // private GameObject Settings;
    //[SerializeField]
    // private GameObject Shop;
    // [SerializeField]
    //private GameObject NoAds;

    [SerializeField]
    private GameObject camera;

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
        FindObjectOfType<audioManager>().Play("Click");
        SceneManager.LoadScene("Level 1");
    }

    public void onClickSurvival()
    {
        FindObjectOfType<audioManager>().Play("Click");
        //SceneManager.LoadScene("Survival");
    }
    public void onClickQuit()
    {
        FindObjectOfType<audioManager>().Play("Click");
    }
    public void onClickShop()
    {
        FindObjectOfType<audioManager>().Play("Click");
        SceneManager.LoadScene("Shop");
    }
    public void onClickSettings()
    {
        FindObjectOfType<audioManager>().Play("Click");
    }
}
