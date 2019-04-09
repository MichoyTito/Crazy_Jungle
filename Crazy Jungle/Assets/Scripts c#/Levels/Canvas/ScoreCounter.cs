using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreCounter : MonoBehaviour
{
    private Text texto;

    // Start is called before the first frame update
    private void Awake()
    {
        
        if (SceneManager.GetActiveScene().name == "Survival")
        {
            this.gameObject.SetActive(true);
            
        }
        else
        {
           
            this.gameObject.SetActive(false);
        }
                
    }

    private void Start()
    {
        texto = this.transform.Find("Puntos").GetComponent<Text>();

    }


    // Update is called once per frame
    void Update()
    {

        texto.text = ((int)(Time.timeSinceLevelLoad * 10)).ToString();
    }
}
