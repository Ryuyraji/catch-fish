using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] cubes;
    public Transform[] points;
    public float beat = 1;
    float timer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer > beat)//1초마다 만들어야 함.만약 시간이 1초가 넘으면 큐브 하나를 만들어 그럼 0으로..?
        {
            timer -= beat;
            GameObject c = Instantiate(cubes[Random.Range(0, 2)], points[Random.Range(0, 4)]);
            //생성하는거 instanstiate
            c.transform.localPosition = Vector3.zero;//상대적인 위치는 없다.
            c.transform.Rotate(transform.forward, 90 * Random.Range(0, 4));//0일때 90,1일때 180..~~

            ;
        }
        timer += Time.deltaTime;//다음번 업데이트가 시작 
    }
}

/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] cubes;
    public Transform[] points;
    public float beat = 1;
    float timer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer > beat)
        {
            timer -= beat;
            // 큐브 생성
            GameObject c = Instantiate(cubes[Random.Range(0, 2)], points[Random.Range(0, 4)]);
            // 생성된 큐브가 앞으로 향하도록 회전값을 설정
            c.transform.localRotation = Quaternion.identity; // 회전값을 초기화하여 큐브가 앞으로 향하게 함
            c.transform.localPosition = Vector3.zero;

            ;
        }
        timer += Time.deltaTime;
    }
}
*/