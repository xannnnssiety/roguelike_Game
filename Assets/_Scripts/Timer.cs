using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private float time;
    public Text timeText;
    private string TimeString;

    private void Start()
    {

        
    }

    public void Update()
    {
        timeText.text = TimeString;
        this.time += Time.deltaTime;
        TimeString = TimeFormat.Format(this.time);
    }


}
