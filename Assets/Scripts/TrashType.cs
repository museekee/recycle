using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TrashArrayType
{
    public TrashType[] Trash;
    public Percentage Percentage;
}

[System.Serializable]
public class TrashType
{
    // int인 이유 : 그냥 쓰레기의 개수만 세주고 쓰레기 이름도 [종류int]기 때문.
    public string Tag; // 쓰레기 종류
    public int Amount; // 쓰레기 개수
}

[System.Serializable]
public class Percentage
{
    public string[] l50l;
}