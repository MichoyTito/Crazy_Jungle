using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ramas : MonoBehaviour
{
    [Header("Pick Ups")]
    [SerializeField]
    private GameObject banana;

    [Header("Obstaculos")]
    [SerializeField]
    private GameObject coco;

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

    private float x1 = -1.3f;
    private float x2 = -1.08f;
    private float x3 = -1.88f;

    private GameObject cloneRama1;
    private GameObject cloneRama2;
    private GameObject cloneRama3;

    private GameObject cloneCoco;
    private GameObject cloneCoco2;
    private GameObject cloneBanana;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnRama1", 3, 3);
        InvokeRepeating("spawnRama2", 6, 4);
        InvokeRepeating("spawnRama3", 9, 2);

        InvokeRepeating("spawnCoco", 11, 7);
        InvokeRepeating("spawnCoco2", 14,9);

        InvokeRepeating("spawnBanana", 4, 7);
    }


    private void spawnRama1()
    {
        float y = Random.Range(-20, -5);

        cloneRama1 = Instantiate(rama1, new Vector3(x1, y, 0), Quaternion.identity);
        cloneRama1.transform.parent = parent.transform;

        if(x1 == 1.3f)
        {
            x1 = -1.3f;
        }
        else
        {
            cloneRama1.transform.localEulerAngles = new Vector3(cloneRama1.transform.rotation.x, 180, cloneRama1.transform.rotation.z);
            x1 = 1.3f;
        }

        Destroy(cloneRama1, 6);
    }
    private void spawnRama2()
    {
        float y = Random.Range(-20, -5);
        cloneRama2 = Instantiate(rama2, new Vector3(x2, y, 0), Quaternion.identity);
        cloneRama2.transform.parent = parent.transform;

        if (x2 == 1.08f)
        {
            x2 = -1.08f;
        }
        else
        {
            cloneRama2.transform.localEulerAngles = new Vector3(cloneRama2.transform.rotation.x, 180, cloneRama2.transform.rotation.z);
            x2 = 1.08f;
        }
        Destroy(cloneRama2, 6);
    }
    private void spawnRama3()
    {
        float y = Random.Range(-20, -5);
        cloneRama3 = Instantiate(rama3, new Vector3(x3, y, 0), Quaternion.identity);
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
    private void spawnCoco()
    {
        float x = Random.Range(-2.15f, 2.1f);

        cloneCoco = Instantiate(coco, new Vector3(x, -8, 0), Quaternion.identity);
        cloneCoco.transform.parent = GameObject.Find("Background").transform;
    }
    private void spawnCoco2()
    {
        float x = Random.Range(-2.15f, 2.1f);

        cloneCoco2 = Instantiate(coco, new Vector3(x, -8, 0), Quaternion.identity);
        cloneCoco2.transform.parent = GameObject.Find("Background").transform;
    }
    private void spawnBanana()
    {
        float x = Random.Range(-2, 2);

        cloneBanana = Instantiate(banana, new Vector3(x, -8, 0), Quaternion.identity);
        cloneBanana.transform.parent = GameObject.Find("Background").transform;
    }
}
