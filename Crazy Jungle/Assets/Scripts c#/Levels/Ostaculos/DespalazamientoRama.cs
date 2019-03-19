using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespalazamientoRama : MonoBehaviour
{


    [Header("Propiedades")]
    [SerializeField]
    private float Velocidad=1f;
    [SerializeField]
    private float aceleracion = 1f;
    [SerializeField]
    private float AlturaMaxima = 7f;



    private Transform rama;


    private void Start()
    {
        rama = GetComponent<Transform>();
        
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        EmpujarRama();

        if (rama.position.y > AlturaMaxima)
        {
            Destroy(this.gameObject);
         }


    }




    private void EmpujarRama()
    {

        float Rapidez = Velocidad + aceleracion * Time.timeSinceLevelLoad;

        rama.Translate(Vector3.up * Rapidez *Time.deltaTime);

    }


}
