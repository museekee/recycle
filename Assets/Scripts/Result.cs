using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour
{
    [SerializeField] Canvas MainUI;
    [SerializeField] Image Gauge;
    [SerializeField] Text GaugeText;
    [SerializeField] Text SuccessText;
    [SerializeField] Text FailText;
    [SerializeField] Text TimeText;
    
    public void Show()
    {
        Trash trash = MainUI.GetComponent<Trash>();
        Score score = MainUI.GetComponent<Score>();
        score.PlayingTimer = false;
        float Percentage = (100 / trash.realBanbok) * score.Success;
        GaugeText.text = $"{Percentage}%";
        Gauge.fillAmount = Percentage / 100;
        SuccessText.text = $"{score.Success}개";
        FailText.text = $"{score.Fail}개";
        TimeText.text = score.nowTime;
        this.gameObject.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene("Mainscene");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
