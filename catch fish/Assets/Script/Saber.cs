/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saber : MonoBehaviour
{
    public LayerMask layer;
    Vector3 prevPos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;//여기랑 레이어가 충돌이 되어야ㅑ
        if (Physics.Raycast(transform.position, transform.forward, out hit, 1, layer))
        {
            if (Vector3.Angle(transform.position - prevPos, hit.transform.up) > 130)
            {//뺀 만큼 휘둘렀다.
                //두 벡터의 사잇값을 구하는 함수 vector3.angle//hit충돌하면 이전포지션 빼면 칼의 방향 130도보다 큰 각도로 부딪치면 
                Destroy(hit.transform.gameObject);//큐브를 사라지게 해라 
                GameManager.IncreaseScore(1);
            }
        }
        prevPos = transform.position;//현재 위치를 이전 프레임의 위치에 넣/
    }
}
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Saber : MonoBehaviour
{
    public LayerMask layer;
    public int score = 0;
    public Text scoreText; // UI 텍스트

    Vector3 prevPos;

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 2, layer))
        {
            if (Vector3.Angle(transform.position - prevPos, hit.transform.up) > 130)
            {     //두 벡터의 사잇값을 구하는 함수 vector3.angle//hit충돌하면 이전포지션 빼면 칼의 방향 130도보다 큰 각도로 부딪치면 
                Destroy(hit.transform.gameObject); // 큐브를 사라지게 해라
                IncreaseScore(); // 점수 증가
            }
        }
        prevPos = transform.position;
    }

    void IncreaseScore()
    {
        score++; // 점수 증가
        UpdateScoreUI(); // UI 업데이트
    }

    void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score.ToString(); // UI 텍스트 업데이트
    }
}

