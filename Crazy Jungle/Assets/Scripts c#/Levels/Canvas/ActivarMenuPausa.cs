using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarMenuPausa : MonoBehaviour
{
    public void Activar()
    {
        this.gameObject.SetActive(true);
    }

    public void Desactivar()
    {
        this.gameObject.SetActive(false);
    }
}
