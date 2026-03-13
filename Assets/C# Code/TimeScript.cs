using UnityEngine;
using TMPro;
using System;

public class TimeScript : MonoBehaviour
{
    public TMP_Text timeText;

    void Start()
    {
        InvokeRepeating("UpdateTime", 0f, 60f); // update every minute
    }

    void UpdateTime()
    {
        try
        {
            TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
            DateTime pstTime = TimeZoneInfo.ConvertTime(DateTime.UtcNow, pstZone);

            timeText.text = $"Local Time\n{pstTime:hh:mm tt}";
        }
        catch
        {
            timeText.text = "Time\nUnavailable";
        }
    }
}