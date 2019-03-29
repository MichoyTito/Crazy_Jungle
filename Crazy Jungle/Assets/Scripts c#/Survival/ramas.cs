using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ramas : MonoBehaviour
{
    [Header("Ramas")]
    [SerializeField]
    private GameObject rama1;
    [SerializeField]
    private GameObject rama2;
    [SerializeField]
    private GameObject rama3;

    [Header("Parent")]
    [SerializeField]
    private GameObject parent;

    private float x1 = -1.55f;
    private float x2 = 1.55f;
    private float x3 = -1.88f;

    private GameObject cloneRama1;
    private GameObject cloneRama2;
    private GameObject cloneRama3;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnRama1", 3, Random.Range(2, 4));
        InvokeRepeating("spawnRama2", 6, Random.Range(2, 4));
        InvokeRepeating("spawnRama3", 9, Random.Range(1.5f, 2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void spawnRama1()
    {

        cloneRama1 = Instantiate(rama1, new Vector3(x1, -5, 0), Quaternion.identity);
        cloneRama1.transform.parent = parent.transform;

        if(x1 == 1.55f)
        {
            x1 = -1.55f;
        }
        else
        {
            cloneRama1.transform.localEulerAngles = new Vector3(cloneRama1.transform.rotation.x, 180, cloneRama1.transform.rotation.z);
            x1 = 1.55f;
        }

        Destroy(cloneRama1, 6);
    }
    private void spawnRama2()
    {

        cloneRama2 = Instantiate(rama2, new Vector3(x2, -8, 0), Quaternion.identity);
        cloneRama2.transform.parent = parent.transform;

        if (x2 == 1.55f)
        {
            x2 = -1.55f;
        }
        else
        {
            cloneRama2.transform.localEulerAngles = new Vector3(cloneRama2.transform.rotation.x, 180, cloneRama2.transform.rotation.z);
            x2 = 1.55f;
        }
        Destroy(cloneRama2, 6);
    }
    private void spawnRama3()
    {

        cloneRama3 = Instantiate(rama3, new Vector3(x3, -6, 0), Quaternion.identity);
        cloneRama3.transform.parent = parent.transform;

        if (x3 == -1.88f)
        {
            x3 = 1.88f;
        }
        else
        {
            cloneRama3.transform.localEulerAngles = new Vector3(cloneRama3.transform.rotation.x, 180, cloneRama3.transform.rotation.z);
            x3 = -1.88f;
        }

        Destroy(cloneRama3, 6);
    }
}
