using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI; // 유니티 엔진의 UI를 가져와서 작업하려고 할때 필요

public class Score : MonoBehaviour
{
    public static int score = 0; // static = 여러개의 인스턴스를 생성해도 클래스에서 관리된다
    public static int bestScore = 0;
    void Start()
    {
        score = 0;
    }

    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = score.ToString(); // Text는 문자형만 가능하다, 그렇기에 int형을 문자형으로 변환해야한다
        // GetComponent<Text>가 아닌 GetComponent<TextMeshProUGUI>로 해야 Component를 불러올 수 있다.
    }
}
