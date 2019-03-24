using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Awake_posicionamiento : MonoBehaviour
{
    private GameObject Alerta;
    private GameObject Coso;
    private GameObject Rayita;

    private void Start()
    {
        //acomodo la alerta
        Alerta = this.transform.Find("Alerta").gameObject;
        Alerta.transform.position =new Vector3(Alerta.transform.position.x , 7.5f , Alerta.transform.position.z);
       // Alerta.GetComponent<SpriteRenderer>().enabled = false;

        //acomodo el coso
        Coso = this.transform.Find("Coso Que cae").gameObject;
        Coso.transform.position = new Vector3(Coso.transform.position.x , 11f , Coso.transform.position.z);



        //Ocultar Trigger(Rayita amarilla)
        Rayita = this.transform.Find("Trigger").gameObject;
        Rayita.GetComponent<SpriteRenderer>().enabled = false;
    }

   


}
