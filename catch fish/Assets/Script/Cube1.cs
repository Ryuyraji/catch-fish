using UnityEngine;

public class Cube1 : MonoBehaviour
{
    void Update()
    {
        transform.position += Time.deltaTime * transform.forward * 2;
    }

    void OnTriggerEnter(Collider other)
    {
        // ���� �浹�� ������Ʈ�� �±װ� "Player"���
        if (other.CompareTag("Blue Player"))
        {
            // ť�긦 �ı��Ѵ�
            Destroy(gameObject);
        }
    }
}
