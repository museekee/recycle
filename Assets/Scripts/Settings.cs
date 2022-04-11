using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    #region 전역변수 선언
    Toggle BGSToggle;
    Toggle BGMToggle;
    #endregion
    void Start()
    {
        #region 전역변수 설정
        BGSToggle = GameObject.Find("BGSToggle").GetComponent<Toggle>();
        BGMToggle = GameObject.Find("BGMToggle").GetComponent<Toggle>();
        #endregion
        #region 오브젝트 설정
        SetObj();
        #endregion
    }

    #region 버튼들
    public void OnClickReset() {
        PlayerPrefs.SetInt("BGSOn", 1);
        PlayerPrefs.SetInt("BGMOn", 1);
        SetObj();
    }
    public void OnClickSave() {
        PlayerPrefs.SetInt("BGSOn", B2I(BGSToggle.isOn));
        PlayerPrefs.SetInt("BGMOn", B2I(BGMToggle.isOn));
        SceneManager.LoadScene("MainScene");
    }
    #endregion

    private void SetObj() {
        BGSToggle.isOn = I2B(PlayerPrefs.GetInt("BGSOn"));
        BGMToggle.isOn = I2B(PlayerPrefs.GetInt("BGMOn"));
    }
    private int B2I(bool boolean) {
        if (boolean) return 1;
        else return 0;
    }
    private bool I2B(int intager) {
        if (intager == 1) return true;
        else return false;
    }
}
