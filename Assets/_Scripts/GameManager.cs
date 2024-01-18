using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text MoneyText;
    public static int Money;
    public static int MoneyDrop = 1;
    void Start()
    {
        Money = PlayerPrefs.GetInt("Money");
    }

    // Update is called once per frame
    void Update()
    {
        MoneyText.text = Money.ToString();
    }
}
