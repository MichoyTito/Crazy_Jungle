using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionesObstaculos : MonoBehaviour
{
    [SerializeField]
    private float DelayReseteo = 1f;




    private void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.tag == "Obstaculo")
        {
            
            Invoke("Reset", DelayReseteo);
        }
   
}


    private void Reset()
    {
        FindObjectOfType<GameManager>().ResetLevel();
    }


}
