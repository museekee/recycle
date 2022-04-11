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
    public void PlayFailAudio() {
        audioSource.clip = FailAudio;
        audioSource.Play();
    }
    public void PlaySuccessAudio() {
        audioSource.clip = SuccessAudio;
        audioSource.Play();
    }
    public void PlayWaterAudio() {
        audioSource.clip = WaterAudio;
        audioSource.Play();
    }
}
