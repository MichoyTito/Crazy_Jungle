using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento_acelerometro : MonoBehaviour
{

    [SerializeField]
    private float FuerzaLateral=1;

    private Rigidbody2D rb;



    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        rb.velocity = new Vector2(FuerzaLateral * Input.acceleration.x, rb.velocity.y);


        Debug.Log(Input.acceleration.x.ToString());

        
    }
}
