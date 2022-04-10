using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
    public void OnClickSetting() {
        GameObject.Find("SettingUI").GetComponent<Canvas>().gameObject.SetActive(true);
    }
}
