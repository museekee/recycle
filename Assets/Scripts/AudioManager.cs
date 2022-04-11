using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource audioSource;
    #region 오디오들
    [SerializeField] public AudioClip FailAudio;
    [SerializeField] public AudioClip SuccessAudio;
    [SerializeField] public AudioClip WaterAudio;
    #endregion

    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }
    public void PlayBGS(string name)
    {
        if (PlayerPrefs.GetInt("BGSOn") == 1){
            switch (name) {
                case "Fail":
                    audioSource.clip = FailAudio;
                    audioSource.Play();
                    break;
                case "Success":
                    audioSource.clip = SuccessAudio;
                    audioSource.Play();
                    break;
                case "Water":
                    audioSource.clip = WaterAudio;
                    audioSource.Play();
                    break;
            }
        }
    }
}
