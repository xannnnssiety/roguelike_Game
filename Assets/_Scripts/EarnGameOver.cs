using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EarnGameOver : MonoBehaviour
{
    public static int MoneyEarn = 0;
    public Text MoneyEarnText;
    public Text Kills;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoneyEarnText.text = MoneyEarn.ToString();
        Kills.text = KillCount.killCount.ToString();
    }
}
