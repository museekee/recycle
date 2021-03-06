using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Text;
using System.Linq;

[System.Serializable]
public class Trash : MonoBehaviour
{
    [SerializeField] GameObject Congrats;
    public int TrashCount = 0;
    private bool OnResult = false;
    public int realBanbok;
    private void FixedUpdate() {
        if (TrashCount == 0 && OnResult == false)
        {
            Congrats.SetActive(true);
            GameObject.Find("Congratulation").GetComponent<Result>().Show();
            OnResult = true;
        }
    }
    private void Start()
    {
        string TrashesJson = Resources.Load("Trashes").ToString();
        var Trashes = JsonUtility.FromJson<TrashArrayType>(TrashesJson);
        int banbok = 50;
        for (int i = 0; i < banbok; i++) {
            int kindRandom = Random.Range(0, Trashes.Trash.Length); // 종류의 랜덤
            string Tag = Trashes.Trash[kindRandom].Tag; // 태그 즉 종류
            int Amount = Trashes.Trash[kindRandom].Amount; // 태그의 파일 수
            int FileRandom = Random.Range(0, Amount); // 파일의 랜덤
            if (Resources.Load($"Trashes/{Tag}/{FileRandom}") != null)
            {
                if (Trashes.Percentage.l50l.Contains($"{Tag}{FileRandom}")) 
                {
                    if (Random.Range(0, 101) < 50) MakeTrash(Tag, FileRandom);
                    else banbok++; continue;
                }
                else MakeTrash(Tag, FileRandom);
                realBanbok++;
                continue;
            }
            if (banbok > 1000) return; // 만에하나 반복이 1000이 넘어가면 반복을 중단하여 에디터의 응답없음이나 프로그램의 응답없음을 방지
            banbok++;
            continue;
        };
    }

    private void MakeTrash(string Tag, int RandomNumber)
    {
        float xRandom = UnityEngine.Random.Range(-300f, 300f);
        float yRandom = UnityEngine.Random.Range(-100f, 100f);
        if (Tag == "Viastic") {
            MakeTrashFunc(RandomNumber, "Btm", "Plastic", xRandom, yRandom, $"Trashes/Viastic/{RandomNumber}Btm");
            MakeTrashFunc(RandomNumber, "Top", "Vinil", xRandom, yRandom, $"Trashes/Viastic/{RandomNumber}Top");
        }
        else MakeTrashFunc(RandomNumber, null, Tag, xRandom, yRandom, $"Trashes/{Tag}/{RandomNumber}");
    }

    private void MakeTrashFunc(int RandomNumber, string TopBtm, string Tag, float x, float y, string ImageAddress)
    {
        TopBtm = TopBtm == null ? "" : TopBtm;
        Transform Panel = GameObject.Find("Trashes").transform; // Panel의 Transform
        GameObject imgObject = new GameObject($"{Tag}/{RandomNumber}{TopBtm}"); // 오브젝트 생성
        imgObject.tag = Tag;
        imgObject.AddComponent<Main>();
        imgObject.AddComponent<BoxCollider2D>();
        imgObject.AddComponent<Rigidbody2D>();
        Rigidbody2D rigidBody2D = imgObject.GetComponent<Rigidbody2D>();
        rigidBody2D.gravityScale = 0f;
        //rigidBody2D.constraints = RigidbodyConstraints2D.FreezePosition;

        RectTransform trans = imgObject.AddComponent<RectTransform>(); // 사이즈 같은거..?
        trans.transform.SetParent(Panel);
        trans.localScale = Vector3.one;
        trans.anchoredPosition = new Vector2(x, y); // 위치
        trans.sizeDelta= new Vector2(75, 75); // 크기
        
        Image image = imgObject.AddComponent<Image>(); // 안의 이미지
        image.sprite = Resources.Load<Sprite>(ImageAddress);
        imgObject.transform.SetParent(Panel);
        TrashCount++;
    }
}
