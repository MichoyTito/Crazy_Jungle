using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bank : MonoBehaviour
{
    [SerializeField]
    private float money;

    [Header("Texts")]
    [SerializeField]
    private Text moneyText;

    public void Start()
    {
        money =  money + PlayerPrefs.GetFloat("Coins");
        moneyText.text = money.ToString("F0");
    }
}
