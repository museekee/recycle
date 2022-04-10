using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
    public void OnClickSetting() {
        SceneManager.LoadScene("SettingScene");
    }
}
