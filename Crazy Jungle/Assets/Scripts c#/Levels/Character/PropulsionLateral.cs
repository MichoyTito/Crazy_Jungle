using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PropulsionLateral : MonoBehaviour
{
    private Vector2 InicioToque;
    private Vector2 FinalToque;

    private bool disparar = false;

    [SerializeField]
    private int DistanciaSwipeMinima = 25;
    [SerializeField]
    private float FuerzaImpulso = 3;
    [SerializeField]
    private float TiempoImpulso = 1;

   


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        foreach (Touch toque in Input.touches)
        {
            if (toque.phase == TouchPhase.Began)
            {
                InicioToque = toque.position;
                FinalToque = toque.position;
            }

            if (toque.phase == TouchPhase.Ended)
            {
                FinalToque = toque.position;
                ProsesarSwipe();

            }
        }

    }


    private void ProsesarSwipe()
    {
        if (ChequearDistancia())
        {
            Vector2 Direccion = FinalToque - InicioToque;


            //Es horrizontal
            if (Mathf.Abs(Direccion.x) > Mathf.Abs(Direccion.y) * 3f)
            {
                //Izquierda
                if (Direccion.x < 0)
                {
                    Impulso("IZQ");
                }
                //Derecha
                if (Direccion.x > 0)
                {
                    Impulso("DER");
                }

            }
            //Es Vertical
            else if(Mathf.Abs(Direccion.y) > Mathf.Abs(Direccion.x) * 3.5f)
            {
                if (Direccion.y > 0)
                {
                    disparar = true;
                }




            }
           


        }


    }


    private bool ChequearDistancia()
    {
        float distancia = Mathf.Sqrt(Mathf.Pow(InicioToque.x - FinalToque.x, 2) + Mathf.Pow(InicioToque.y - FinalToque.y, 2));

        if (distancia > DistanciaSwipeMinima)
        {
            return true;
        }
        else
        {
            return false;
        }

    }



    private void Impulso(string direccion)
    {
        //desactivo el acelerometro
        GetComponent<Movimento_acelerometro>().enabled = false;



        if (direccion == "DER")
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.right * FuerzaImpulso);
        }
        else if (direccion == "IZQ")
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.left * FuerzaImpulso);
        }
        else
        {
            Debug.Log("ERROR EN EL SCRIPT:PROPULSION LATERAL");
        }

        //Activo el acelerometro
        Invoke("ReactivarAcelerometro", TiempoImpulso);
        
    }
    private void ReactivarAcelerometro()
    {
        GetComponent<Movimento_acelerometro>().enabled = true;
    }


     public bool GetAndSetDisparar()
    {
        if (disparar == false)
        {
            return false;
        }
        else
        {
            disparar = false;
            return true;
        }



    }

}


