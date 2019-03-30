using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
 

    public void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void PauseLevel()
    {
        Time.timeScale = 0;//Paro el tiempo

        //desactivo la capacidad del mono de tirar bananas
        GameObject[] lista = FindObjectsOfType<GameObject>();
        for(int i = 0; i < lista.Length; i++)
        {
            if (lista[i].tag == "Player")
            {
                lista[i].GetComponent<BananaManager>().enabled = false;
            }
        }
    }

    public void ResumeLevel()
    {
        //Activo la capacidad del mono de tirar bananas
        GameObject[] lista = FindObjectsOfType<GameObject>();
        for (int i = 0; i < lista.Length; i++)
        {
            if (lista[i].tag == "Player")
            {
                lista[i].GetComponent<BananaManager>().enabled = true;
            }
        }


        



        //Activo el tiempo
        Time.timeScale = 1;

    }

}
