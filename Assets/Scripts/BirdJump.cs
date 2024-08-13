using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Scene를 넘어가도록 하는 코드를 사용하는데 필요하다

// 전체적인 흐름만 이해하면 구글에 검색하여 코드를 사용할 수도 있다.
public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb; // Rigidboody2D를 담을 수 있는 객체 생성
    public float jumpPower; // public으로 선언하면 unity editor에서 수정가능
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Rigidbody2D를 가져옴
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) { // GetMouseButtonDown = 마우스 버튼이 눌러졌을때 (스마트폰이 클릭됬을때), 괄호안의 0 = 마우스의 왼쪽버튼 
            rb.velocity = Vector2.up * jumpPower; // velocity = 속도를 나타내는 속성, Vector2.up = (0,1) 
            GetComponent<AudioSource>().Play();
        }
    }

    /// <summary>
    /// Sent when an incoming collider makes contact with this object's
    /// collider (2D physics only).
    /// </summary>
    /// <param name="other">The Collision2D data associated with this collision.</param>
    private void OnCollisionEnter2D(Collision2D other) { // Trigger와 구분하기
        if (Score.score > Score.bestScore) {
            Score.bestScore = Score.score;
        }
        SceneManager.LoadScene("GameOverScene");
    }
}
