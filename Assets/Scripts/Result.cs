using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    public void Show()
    {
        Trash trash = GameObject.Find("MainUI").GetComponent<Trash>();
        Score score = GameObject.Find("MainUI").GetComponent<Score>();
        float Percentage = (100 / trash.realBanbok) * score.Success;
        GameObject.Find("GaugeText").GetComponent<Text>().text = $"{Percentage}%";
        GameObject.Find("Gauge").GetComponent<Image>().fillAmount = Percentage / 100;
        this.gameObject.SetActive(true);
    }
}
