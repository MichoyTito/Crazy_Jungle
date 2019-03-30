using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DelayResume : MonoBehaviour
{
    private Text texto;
    [SerializeField]
    private float DelayEntreNumeros=1f;

    private void Awake()
    {
        texto = this.GetComponent<Text>();
    }



    public void EsperarYResume()
    {
        this.gameObject.SetActive(true);


        //_______________________3...
        texto.text = "3";

        int FontDefault = texto.fontSize;

        float TiempoInicial = Time.time;//Agrandamiento de Numeros;
        while (Time.time <= TiempoInicial + DelayEntreNumeros)
        {
            texto.fontSize++;
        }

        //______________________2...

        texto.fontSize = FontDefault;
        texto.text = "2";


        TiempoInicial = Time.time;//Agrandamiento de Numeros;
        while (Time.time <= TiempoInicial + DelayEntreNumeros)
        {
            texto.fontSize++;
        }

        //______________________1..
        texto.fontSize = FontDefault;
        texto.text = "1";


        TiempoInicial = Time.time;//Agrandamiento de Numeros;
        while (Time.time <= TiempoInicial + DelayEntreNumeros)
        {
            texto.fontSize++;
        }

        //__________YA!!
        FindObjectOfType<GameManager>().ResumeLevel();




        this.gameObject.SetActive(false);
    }

    
}
