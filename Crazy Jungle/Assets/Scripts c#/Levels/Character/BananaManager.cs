using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaManager : MonoBehaviour
{
    [Header("Bananas")]
    [SerializeField]
    private float DelayDisparos = 1;

    private float UltimoDisparo = 0;

    private Vector3 posisionUltimaBanana = new Vector3(10000f, 10000f, 10000f);


    private Vector2 pos_dedo_inicial;
    private Vector2 pos_dedo_movido;
    private bool apuntando = false;
    [SerializeField]
    private float min_distance_swipe = 20;



    [SerializeField]
    private int CantidadBananas = 0;
    [SerializeField]
    private Rigidbody2D PrefabProyectil;


    private void OnTriggerEnter2D(Collider2D Other)
    {

        if (Other.tag == "Banana")
        {
            if (Other.transform.position != posisionUltimaBanana)
            {
                if (Other.transform.position != null)
                {
                    Destroy(Other.gameObject);

                    posisionUltimaBanana = Other.transform.position;

                    CantidadBananas++;
                }
            }
        }

    }

    private void Start()
    {
        apuntando = false;
        pos_dedo_inicial = new Vector2(9999f, 99999f);
    }



    private void Update()
    {
        DisparoNuevo();
      

    }

    //Desliza para abajo para disparar(necesita SaltoLateral)
    private void DisparoViejo()
    {
        //Dispara Bananas

        if (GetComponentInChildren<SaltoLateral>().GetDisparar() || Input.GetKeyDown(KeyCode.Space))//Desliza el dedo o apreta space
        {

            if (UltimoDisparo + DelayDisparos < Time.time)//Si paso suficiente tiempo desde el ultimo disparo
            {
                if (CantidadBananas > 0)//si tiene bananas
                {
                    Instantiate(PrefabProyectil, this.transform.position, Quaternion.identity);

                    UltimoDisparo = Time.time;

                    CantidadBananas--;


                }
            }
            GetComponentInChildren<SaltoLateral>().SetDispararFalse();
        }
    }


    //Desliza para arriba y despues para abajo para disparar
    private void DisparoNuevo()
    {
        if (Input.touchCount > 0)
        {
            Touch toque = Input.touches[0];

            if (toque.phase == TouchPhase.Began||toque.phase==TouchPhase.Stationary)
            {
                pos_dedo_inicial = toque.position;
            }
            if (toque.phase == TouchPhase.Moved)
            {
                
                    if (toque.position.y > pos_dedo_inicial.y + min_distance_swipe && !apuntando)
                    {

                        apuntando = true;
                        pos_dedo_inicial = toque.position;
                    }
                    if (toque.position.y < pos_dedo_inicial.y - min_distance_swipe && apuntando)
                    {
                        apuntando = false;
                        pos_dedo_inicial = toque.position;

                        if (UltimoDisparo + DelayDisparos < Time.time)//Si paso suficiente tiempo desde el ultimo disparo
                        {
                            if (CantidadBananas > 0)//si tiene bananas
                            {
                                Instantiate(PrefabProyectil, this.transform.position, Quaternion.identity);

                                UltimoDisparo = Time.time;

                                CantidadBananas--;


                            }
                        }
                    }
                
            }

            if (toque.phase == TouchPhase.Ended)
            {
                apuntando = false;
            }

        }

      
    }
    public int GetCantidadBananas()
    {
        return CantidadBananas;
    }
}
