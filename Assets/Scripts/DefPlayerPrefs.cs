using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefPlayerPrefs : MonoBehaviour
{
    void Start()
    {
        if (!PlayerPrefs.HasKey("BGSOn")) PlayerPrefs.SetInt("BGSOn", 1);
        if (!PlayerPrefs.HasKey("BGMOn")) PlayerPrefs.SetInt("BGMOn", 1);
    }
}
