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
        Debug.Log(trash.realBanbok);
        Debug.Log(score.Success);
        GameObject.Find("GaugeText").GetComponent<Text>().text = $"{((100 / trash.realBanbok) * score.Success)}%";
        this.gameObject.SetActive(true);
    }
}
