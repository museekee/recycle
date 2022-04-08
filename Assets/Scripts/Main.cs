using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

// 4월 3일의 나야 어떻게든 막 JSON Array를 써서라도 쓰레기 동적 생성 해라
/*
[
    {
        "Name": "라면",
        "Tag": "Vinil"
    },
    {
        "Name": "삼다수",
        "Tag": "Plastic"
    }
]
또는
{
    "Vinil": [
        "라면"
    ],
    "Plastic": [
        "삼다수"
    ]
}
난 2번 할래!
*/
// 2022-04-02-오전 11시쯤? 개발 시작
public class Main : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    #region GlobalVariable
    private Text SuccessText;
    private Text FailText;
    private static Vector2 DefaultPos;
    private static string mDrag = "true";
    private static GameObject canvas;
    #endregion

    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        mDrag = "true";
    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        if (mDrag == "true"){
            this.transform.position = new Vector3(eventData.position.x, eventData.position.y, 5f);
            return;
        }
        eventData.pointerDrag = null;
        if (mDrag == "Right") this.transform.position = new Vector2(this.transform.position.x - 5, this.transform.position.y);
        else if (mDrag == "Left") this.transform.position = new Vector2(this.transform.position.x + 5, this.transform.position.y);
    }

    void OnTriggerEnter2D(Collider2D o) 
    {
        // 아 벽뚫기 안 막아-2
        // 여기서 this는 드래그 이벤트?고 this.gameObject는 그 Image인듯.-1
        Score score = GameObject.Find("MainUI").GetComponent<Score>();
        switch (o.name) {
            case "RightWall":
                mDrag = "Right";
                return;
            case "LeftWall":
                mDrag = "Left";
                return;
            case "Water":
                //o.gameObject.name = "Plastic0";
                //o.gameObject.tag = "Plastic";
                this.gameObject.name = this.name.ToString().Replace("Water", "");
                this.gameObject.tag = this.tag.Replace("Water", "");
                this.gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>($"Trashes/{this.name.Replace("Water", "")}");
                return;
        };
        Destroy(this);
        Destroy(this.gameObject);
        if (o.name == $"{this.tag}Can") score.Success++;
        else score.Fail++;
        // GameObject.Find("MainUI").GetComponent<Trash>().MakeTrash("Vinil");
        // ^ 테스트용
    }
}
