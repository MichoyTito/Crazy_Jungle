using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivaGravedad_coso : MonoBehaviour
{

    private Rigidbody2D rb;
    public GameObject Padre;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Transform>().position.y < -10f)
        {
            Padre.GetComponent<DestroyThis>().DestroyThisPrefab();
        }
    }
}
