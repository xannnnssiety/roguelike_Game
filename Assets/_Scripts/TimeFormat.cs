using System;
using UnityEngine;

/*форматирование времени в 00:00*/
public static class TimeFormat
{
    public static string Format(float seconds)
    {
        TimeSpan ts = TimeSpan.FromSeconds(seconds);


        if (ts.Minutes != 0) return ts.Minutes + ":" + ts.Seconds;
        else if (ts.Seconds != 0) return "00:" + ts.Seconds;
        else
        {
            Debug.Log(message: "{GameLog}");
            return "";
        }


    }
}
