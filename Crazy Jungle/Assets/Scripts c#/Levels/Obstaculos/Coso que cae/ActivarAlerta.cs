using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarAlerta : MonoBehaviour
{

    
    private GameObject monkey;
    private bool YaActivado = false;
    
    public GameObject Alerta;


    // Start is called before the first frame update
    void Awake()
    {
     GameObject [] Lista = GameObject.FindObjectsOfType<GameObject>();
        for(int i = 0; i < Lista.Length; i++)
        {
            if (Lista[i].tag == "Player")
            {
                monkey = Lista[i];
            }
        }


        
        
    }

    // Update is called once per frame
    void Update()
    {

        if (!YaActivado)
        {
            if (monkey.transform.position.y <= this.transform.position.y)
            {
                YaActivado = true;
                Alerta.GetComponent<Parpadea>().enabled = true;
                
                
            }
        }


    }
}
