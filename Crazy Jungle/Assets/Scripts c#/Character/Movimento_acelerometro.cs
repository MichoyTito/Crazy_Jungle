using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento_acelerometro : MonoBehaviour
{
    //Variables para ajustar como se mueve
    [Header("Fuerzas Movimiento:")]
    [SerializeField]
    private float FuerzaLateral_PC = 1;
    [SerializeField]
    private float FuerzaLateral_Celular = 1;


    //Bool que indica si se va a usar el teclado o Unity Remote
    [Header("Input: ")]
    [SerializeField]
    private bool UnityRemote_Conectado=false;


    //Pedidos en Start()
    private Rigidbody2D rb;
    private Vector3 InclinacionInicial;


  


    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        InclinacionInicial = Input.acceleration;

    }

    // Update is called once per frame
    void Update()
    {
        if (UnityRemote_Conectado)
        {
            moveCelular();
            
        }

        else
        {
            movePC();
        }

    
    }




    //Funcion para mover el personaje inclinando el celular
    private void moveCelular()
    {
        float Despalazamiento_X = (FuerzaLateral_Celular * Input.acceleration.x) - InclinacionInicial.x;

        rb.velocity = new Vector2(Despalazamiento_X, rb.velocity.y);
    }



    // Funcion para mover el personaje con el teclado
    private void movePC()
    {   
        float Direccion = Input.GetAxisRaw("Horizontal");


        rb.velocity = new Vector2(FuerzaLateral_PC * Direccion, rb.velocity.y);
    }
}
