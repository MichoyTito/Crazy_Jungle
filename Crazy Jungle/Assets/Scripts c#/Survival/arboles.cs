using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arboles : MonoBehaviour
{
    [Header("Arboles")]
    [SerializeField]
    private GameObject arbol1;
    [SerializeField]
    private GameObject arbol2;

    [SerializeField]
    private GameObject parent;

    private float z = 2.01f;

    private GameObject cloneArbol1;
    private GameObject cloneArbol2;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnArbol1", 0.7f, 0.7f);
        InvokeRepeating("spawnArbol2", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void spawnArbol1()
    {

        cloneArbol1 = Instantiate(arbol1, new Vector3(0, -15, z), Quaternion.identity);
        cloneArbol1.transform.parent = parent.transform;
        Destroy(cloneArbol1, 10);
        
        z += 0.01f;
    }
    void spawnArbol2()
    {
        cloneArbol2 = Instantiate(arbol2, new Vector3(0, -20, z), Quaternion.identity);       
        cloneArbol2.transform.parent = parent.transform;
        cloneArbol2.transform.localEulerAngles = new Vector3(cloneArbol2.transform.rotation.x, 180, cloneArbol2.transform.rotation.z);
        Destroy(cloneArbol2, 10);

        z += 0.01f;
    }
}
