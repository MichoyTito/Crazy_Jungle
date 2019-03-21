using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class invokeMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("loadMenu", 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void loadMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
