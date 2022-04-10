using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int Success = 0;
    public int Fail = 0;
    private AudioSource audioSource;
    [SerializeField] public AudioClip FailAudio;
    [SerializeField] public AudioClip SuccessAudio;
    
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        Text SuccessText = GameObject.Find("Success").GetComponent<Text>();
        Text FailText = GameObject.Find("Fail").GetComponent<Text>();
        SuccessText.text = $"성공 : {Success}개";
        FailText.text = $"실패 : {Fail}개";
    }

    public void PlayFailAudio() {
        audioSource.clip = FailAudio;
        audioSource.Play();
    }

    public void PlaySuccessAudio() {
        audioSource.clip = SuccessAudio;
        audioSource.Play();
    }
}
