using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorBananas : MonoBehaviour
{

    private Text texto;
    private GameObject Mono;

    // Start is called before the first frame update
    void Start()
    {
        texto = GetComponent<Text>();

        //Encuentro el mono
        GameObject[] Array = FindObjectsOfType<GameObject>();
        for(int i = 0; i < Array.Length; i++)
        {
            if (Array[i].tag == "Player")
            {
                Mono = Array[i];
            }
        }



    }

    // Update is called once per frame
    void Update()
    {
        texto.text = "X" + Mono.GetComponent<BananaManager>().GetCantidadBananas().ToString();

    }
}
