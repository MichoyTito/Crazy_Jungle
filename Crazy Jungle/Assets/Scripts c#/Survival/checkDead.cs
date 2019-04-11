using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkDead : MonoBehaviour
{
    [SerializeField]
    private GameObject deadPanel;
    [SerializeField]
    private GameObject sprite;

    private void OnTriggerEnter2D(Collider2D Other)
    {
        //Obstaculos
        if (Other.tag == "Obstaculo")
        {
            deadPanel.GetComponent<lose>().Dead();
            sprite.SetActive(false);
        }

    }
}
