using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilBanana : MonoBehaviour
{


    [SerializeField]
    private float FuezaImpulso = 20;


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector3.down * FuezaImpulso);
    }

    private void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.tag == "Obstaculo")
        {
            Destroy(Other.gameObject);


            Destroy(this.gameObject);

        }



    }




    private void FixedUpdate()
    {
        GetComponent<Transform>().Rotate(new Vector3(0, 0, 15));
    }

}
