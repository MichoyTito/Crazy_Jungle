using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento_acelerometro : MonoBehaviour
{
    [Header("Floats")]
    [SerializeField]
    private float FuerzaLateral = 1;



    private Rigidbody2D rb;


    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move();

        
    }


    // Funcion para el movimiento del personaje
    private void move()
    {
        float move = Input.GetAxisRaw("Horizontal");


        rb.velocity = new Vector2(FuerzaLateral * move, rb.velocity.y);
    }
}
