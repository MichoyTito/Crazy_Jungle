using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Pressed_Button : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    //Este script es para que el boton que ayuda al movimienot del mono se active mientras esta presionado



    GameObject mono;

    private void Awake()
    {
        GameObject[] Lista = FindObjectsOfType<GameObject>();
        for(int i = 0; i < Lista.Length; i++)
        {
            if (Lista[i].tag == "Player")
            {
                mono = Lista[i];
            }
        }
    }



    public void OnPointerDown(PointerEventData eventData)
    {
        mono.GetComponent<Movimient_mono_dedo>().ScreenPressed = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        mono.GetComponent<Movimient_mono_dedo>().ScreenPressed = false;
    }
   
    
}
