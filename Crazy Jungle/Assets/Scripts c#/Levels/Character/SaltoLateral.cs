using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SaltoLateral : MonoBehaviour
{
    private Vector2 InicioToque;
    private Vector2 FinalToque;

    private bool disparar = false;

    [SerializeField]
    private int DistanciaSwipeMinima = 25;
    [SerializeField]
    private float FuerzaImpulso = 1000f;
    [SerializeField]
    private float TiempoImpulso = 0.2f;//ESto probablemente lo raje a la mierda


    private bool TocandoArbol = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Tree")
        {
            GetComponent<Movimento_acelerometro>().enabled = true;
            TocandoArbol = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Tree")
        {
           
            TocandoArbol = false;
        }
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
                else if (Mathf.Abs(Direccion.y) > Mathf.Abs(Direccion.x) * 3.5f)
                {
                    if (Direccion.y < 0)
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

        if (TocandoArbol)
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

            //Activo el acelerometro en OnEnterColission2D()
         
        }
    }



    public bool GetDisparar()
    {
        return disparar;
    }
    public void SetDispararFalse()
    {
        disparar = false;
    }

}

