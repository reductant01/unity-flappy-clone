using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    public float timeDiff;
    float timer = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; // fps에 관계없이 똑같은 시간이 흘렀을 떄를 정하기 위해 사용
        if (timer > timeDiff)
        {
            GameObject newpipe = Instantiate(pipe); // 매 프레임마다 Pipe가 생성되므로 생성주기를 조절할 필요가 있다
            newpipe.transform.position = new Vector3(pipe.transform.position.x, Random.Range(-4.5f, 2.0f), 0f); // Prefabs로 정해놓은 pipe의 위치에서 y좌표만 변화하여 생성
            timer = 0;
            Destroy(newpipe, 10.0f);
        }
        
    }
}
