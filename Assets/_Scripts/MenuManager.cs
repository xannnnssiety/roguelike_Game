using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Text MoneyTextMenu;
    public static int MoneyMenu;

    public GameObject ChooseLvl;

    public GameObject ShopBuff;
    void Start()
    {
        ChooseLvl.SetActive(false);
        ShopBuff.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        MoneyTextMenu.text = PlayerPrefs.GetInt("Money").ToString();
    }

    public void OpenShopBuff()
    {
        ShopBuff.SetActive(true);
    }

    public void CloseShopBuff()
    {
        ShopBuff.SetActive(false);
    }

    public void OpenLvl()
    {
        ChooseLvl.SetActive(true);
    }

    public void CloseLvl()
    {
        ChooseLvl.SetActive(false);
    }


    public void SetPlayer(int index)
    {
        PlayerPrefs.SetInt("Player", index);
    }

    public void mm()
    {
        MoneyMenu = 1000;
    }

    public void mmPlus()
    {
        MoneyMenu += 1000;
    }
}
