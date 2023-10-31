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
        RaycastHit hit;//����� ���̾ �浹�� �Ǿ�ߤ�
        if (Physics.Raycast(transform.position, transform.forward, out hit, 1, layer))
        {
            if (Vector3.Angle(transform.position - prevPos, hit.transform.up) > 130)
            {//�� ��ŭ �ֵѷ���.
                //�� ������ ���հ��� ���ϴ� �Լ� vector3.angle//hit�浹�ϸ� ���������� ���� Į�� ���� 130������ ū ������ �ε�ġ�� 
                Destroy(hit.transform.gameObject);//ť�긦 ������� �ض� 
                GameManager.IncreaseScore(1);
            }
        }
        prevPos = transform.position;//���� ��ġ�� ���� �������� ��ġ�� ��/
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
    public Text scoreText; // UI �ؽ�Ʈ

    Vector3 prevPos;

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 2, layer))
        {
            if (Vector3.Angle(transform.position - prevPos, hit.transform.up) > 130)
            {     //�� ������ ���հ��� ���ϴ� �Լ� vector3.angle//hit�浹�ϸ� ���������� ���� Į�� ���� 130������ ū ������ �ε�ġ�� 
                Destroy(hit.transform.gameObject); // ť�긦 ������� �ض�
                IncreaseScore(); // ���� ����
            }
        }
        prevPos = transform.position;
    }

    void IncreaseScore()
    {
        score++; // ���� ����
        UpdateScoreUI(); // UI ������Ʈ
    }

    void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score.ToString(); // UI �ؽ�Ʈ ������Ʈ
    }
}

