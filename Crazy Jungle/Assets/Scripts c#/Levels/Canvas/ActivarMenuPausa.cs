using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivarMenuPausa : MonoBehaviour
{

    [SerializeField]
    private GameObject cameraMain;
    [SerializeField]
    private GameObject loadScreen;
    [SerializeField]
    private GameObject canvas;

    public void Activar()
    {
        this.gameObject.SetActive(true);
    }

    public void Desactivar()
    {
        this.gameObject.SetActive(false);
    }
    public void Menu()
    {
        SceneManager.LoadScene("Main Menu");
    }

}
