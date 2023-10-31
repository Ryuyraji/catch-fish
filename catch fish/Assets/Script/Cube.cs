using UnityEngine;

public class Cube : MonoBehaviour
{
    void Update()
    {
        transform.position += Time.deltaTime * transform.forward * 2;
    }

    void OnTriggerEnter(Collider other)
    {
        // ���� �浹�� ������Ʈ�� �±װ� "Player"���
        if (other.CompareTag("Red Player"))
        {
            // ť�긦 �ı��Ѵ�
            Destroy(gameObject);
        }
    }
}
