using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLlegada : MonoBehaviour
{
    [SerializeField]
    private float DelayWin = 3f;

    

    private void OnTriggerEnter2D(Collider2D Other)
    {
       

        if (Other.tag == "Trigger Gravity")
        {
            EnableGravity();
        }
        if (Other.tag == "Trigger StopWater")
        {
            StopWater(Other.gameObject);
        }
        if (Other.tag == "Agua")
        {
            Salpicadura(Other.gameObject);
            Invoke("Reset", DelayWin);
        }



    }

    //El mono emieza a caer enla pantalla
    private void EnableGravity()
    {
        GetComponent<Rigidbody2D>().gravityScale = 1f;
    }


    //El agua para de subir
    private void StopWater(GameObject Other)
    {
        Other.gameObject.GetComponentInParent<DespalazamientoRama>().enabled = false;
    }

    //Salpica
    private void Salpicadura(GameObject Other)
    {
        GameObject Splash = Other.transform.Find("Water Splash").gameObject;

        Splash.GetComponent<Transform>().position = gameObject.GetComponent<Transform>().position;

        Splash.SetActive(true);       
    }



    //Se carga de vuelta el nivel(Llama al GamaManager)
    private void Reset()
    {
        FindObjectOfType<GameManager>().ResetLevel();
    }

}