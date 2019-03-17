using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionesObstaculos : MonoBehaviour
{
    
    [SerializeField]
    private float DelayChoque = 1f;
  




    private void OnTriggerEnter2D(Collider2D Other)
    {
        //Obstaculos
        if (Other.tag == "Obstaculo")
        {
            
            Invoke("Reset", DelayChoque);
        }

    }


    private void Reset()
    {
        FindObjectOfType<GameManager>().ResetLevel();
    }

   

}
