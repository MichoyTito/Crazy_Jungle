using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyThis : MonoBehaviour
{
    public void DestroyThisPrefab (){
        Destroy(this.gameObject);

        }
}
