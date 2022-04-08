using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int Success = 0;
    public int Fail = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text SuccessText = GameObject.Find("Success").GetComponent<Text>();
        Text FailText = GameObject.Find("Fail").GetComponent<Text>();
        SuccessText.text = $"성공 : {Success}개";
        FailText.text = $"실패 : {Fail}개";
    }
}
