using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaManager : MonoBehaviour
{
    [Header("Bananas")]
    [SerializeField]
    private float DelayDisparos = 1;

    private float UltimoDisparo = 0;

    [SerializeField]
    private int CantidadBananas = 0;
    [SerializeField]
    private Rigidbody2D PrefabProyectil;


    private void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.tag == "Banana")
        {
            CantidadBananas++;
          
            Destroy(Other.gameObject);
        }
        
    }

    private void Update()
    {
        //Dispara Bananas

        if (CantidadBananas > 0)//Si tiene Bananas
        {
            if (UltimoDisparo + DelayDisparos < Time.time)//Si paso suficiente tiempo desde el ultimo disparo
            {
                if (Input.touchCount > 0 || Input.GetKeyDown(KeyCode.Space))//si toca la pantalla o Space
                {
                    Instantiate(PrefabProyectil, this.transform.position, Quaternion.identity);

                    UltimoDisparo = Time.time;

                    CantidadBananas--;
                }
            }
        }
    }



    public int GetCantidadBananas()
    {
        return CantidadBananas;
    }

}
