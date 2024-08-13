using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime; // transform 속성은 기본적으로 가지고 오는 속성이므로 GetComponent를 사용할 필요가 없다
        // Vector3.left = (-1,0,0), Time.deltaTime = 지난 프레임이 완료되는데 까지 걸린 시간 => fps보정용으로 사용
        // Debug.Log(transform.position); 
    }
}
