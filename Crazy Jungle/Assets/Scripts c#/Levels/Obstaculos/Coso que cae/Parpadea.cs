using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parpadea : MonoBehaviour
{

 
    private SpriteRenderer render;
    private int i = 0;


    public GameObject coso;
    [Header("Parpadeo")]
    [SerializeField]
    private int Cantidad_Iterciones=100;


    // Start is called before the first frame update
    void Start()
    {
        render = this.GetComponent<SpriteRenderer>();
        i = 0;
        render.enabled = true;
    }

    //FixedUpdate se repite 50 veces por segundo
    void FixedUpdate()
    {
        if (i < Cantidad_Iterciones)
        {
            if (i % 10 < 5)
            {
                render.color = Color.yellow;
            }
            else
            {
                render.color = Color.red;
            }
        }
        else
        {
            render.enabled = false;
            coso.GetComponent<ActivaGravedad_coso>().enabled = true;
            
        }

        //Sumo uno a la iteracion
        i++;
         
    }


    

}
