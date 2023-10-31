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
        if (timer > beat)//1�ʸ��� ������ ��.���� �ð��� 1�ʰ� ������ ť�� �ϳ��� ����� �׷� 0����..?
        {
            timer -= beat;
            GameObject c = Instantiate(cubes[Random.Range(0, 2)], points[Random.Range(0, 4)]);
            //�����ϴ°� instanstiate
            c.transform.localPosition = Vector3.zero;//������� ��ġ�� ����.
            c.transform.Rotate(transform.forward, 90 * Random.Range(0, 4));//0�϶� 90,1�϶� 180..~~

            ;
        }
        timer += Time.deltaTime;//������ ������Ʈ�� ���� 
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
            // ť�� ����
            GameObject c = Instantiate(cubes[Random.Range(0, 2)], points[Random.Range(0, 4)]);
            // ������ ť�갡 ������ ���ϵ��� ȸ������ ����
            c.transform.localRotation = Quaternion.identity; // ȸ������ �ʱ�ȭ�Ͽ� ť�갡 ������ ���ϰ� ��
            c.transform.localPosition = Vector3.zero;

            ;
        }
        timer += Time.deltaTime;
    }
}
*/