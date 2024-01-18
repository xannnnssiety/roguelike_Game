using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockButton : MonoBehaviour
{
    public static int levelComplete;
    public Button level2;
    public Button level3;
    public Button level4;
    public Button levelInf;

    // Start is called before the first frame update
    void Start()
    {
        levelComplete = PlayerPrefs.GetInt("lvlComplete");
        level2.interactable = false;
        level3.interactable = false;
        level4.interactable = false;
        levelInf.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(levelComplete >= 1)
        {
            level2.interactable = true;
        }
        if (levelComplete >= 2)
        {
            level3.interactable = true;
        }
        if (levelComplete >= 3)
        {
            level4.interactable = true;
        }
        if (levelComplete >= 4)
        {
            levelInf.interactable = true;
        }
    }

    public void mm()
    {
        levelComplete += 1;
        PlayerPrefs.SetInt("lvlComplete", levelComplete);
    }

    public void DeleteMM()
    {
        PlayerPrefs.DeleteKey("lvlComplete");
    }
}
