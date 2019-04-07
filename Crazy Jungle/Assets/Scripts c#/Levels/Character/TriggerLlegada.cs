using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLlegada : MonoBehaviour
{
    [SerializeField]
    private float DelayWin = 3f;

    private GameObject arboles;

    


    //Consegir los arboles
    private void Awake()
    {
        GameObject[] Lista = FindObjectsOfType<GameObject>();
        for(int i = 0; i < Lista.Length; i++)
        {
            if (Lista[i].name == "Background")
            {
                arboles = Lista[i].transform.Find("Arboles").gameObject;
            
            }
        }



    }



    private void OnTriggerEnter2D(Collider2D Other)
    {
       

        if (Other.tag == "Trigger Gravity")
        {
            EnableGravity(Other.gameObject);
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

    //El mono emieza a caer enla pantalla y los arboles dejan de subir
    private void EnableGravity(GameObject Other)
    {
        this.GetComponent<Movimient_mono_dedo>().enabled = false;//Esto por qur rl sistema de movimerto puede reducir la velocidad del mono

        GetComponent<Rigidbody2D>().drag = 0.1f;
        GetComponent<Rigidbody2D>().velocity = new Vector3(0f, ((-10)*Other.GetComponentInParent<Rigidbody2D>().velocity.y), 0f);
        GetComponent<Rigidbody2D>().gravityScale = 1.5f;

        arboles.GetComponent<desplazamientoSinDestruir>().enabled = false;

       
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

        Splash.GetComponent<Transform>().position = gameObject.GetComponent<Transform>().position + new Vector3(0, -1, 0);


        Splash.SetActive(true);       
    }



    //Se carga de vuelta el nivel(Llama al GamaManager)
    private void Reset()
    {
        FindObjectOfType<GameManager>().ResetLevel();
    }

}