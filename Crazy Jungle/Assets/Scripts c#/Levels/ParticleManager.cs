using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    public GameObject Particulas_Tronco;

    private void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.tag == "Player")
        {
            Particulas_Tronco.SetActive(true);
            
        }
    }

    private void OnTriggerExit2D(Collider2D Other)
    {
        if (Other.tag == "Player")
        {
            Particulas_Tronco.SetActive(false);
           
        }
    }


}
