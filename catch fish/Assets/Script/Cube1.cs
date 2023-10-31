using UnityEngine;

public class Cube1 : MonoBehaviour
{
    void Update()
    {
        transform.position += Time.deltaTime * transform.forward * 2;
    }

    void OnTriggerEnter(Collider other)
    {
        // 만약 충돌한 오브젝트의 태그가 "Player"라면
        if (other.CompareTag("Blue Player"))
        {
            // 큐브를 파괴한다
            Destroy(gameObject);
        }
    }
}
