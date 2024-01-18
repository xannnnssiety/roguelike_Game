using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillCount : MonoBehaviour
{

    public static int killCount;

    public Text killCountText;
    
    void Start()
    {
        killCount = 0;
        
    }

    
    void Update()
    {
        killCountText.text = killCount.ToString();
    }
}
