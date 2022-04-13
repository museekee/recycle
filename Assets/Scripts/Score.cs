using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Score : MonoBehaviour
{
    public int Success = 0;
    public int Fail = 0;
    private float TotalSeconds;
    public string nowTime;
    public bool PlayingTimer = true;
    [SerializeField] public Text SuccessText;
    [SerializeField] public Text FailText;
    [SerializeField] public Text Timer;

    void Update()
    {
        SuccessText.text = $"성공 : {Success}개";
        FailText.text = $"실패 : {Fail}개";
        if (PlayingTimer) Stopwatch();
    }

    private void Stopwatch() 
    {
        TotalSeconds += Time.deltaTime; 
        TimeSpan timespan = TimeSpan.FromSeconds(TotalSeconds); 
        nowTime = string.Format("{0:0}:{1:00}.{2:00}", 
            timespan.Minutes, timespan.Seconds, timespan.Milliseconds);
        Timer.text = nowTime;
    } 
}
