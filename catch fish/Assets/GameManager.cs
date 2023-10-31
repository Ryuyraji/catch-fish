/*using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;  // �̱��� ������ ����Ͽ� GameManager �ν��Ͻ��� �����մϴ�.
    public Text scoreText; // ������ ����� UI �ؽ�Ʈ
    private int score = 0; // ���� ����
    private bool isGameover = false; // ���� ���� ���� ����
    
   

    private void Awake()
    {
        // GameManager�� �ν��Ͻ��� �����մϴ�.
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.LogWarning("���� �ΰ� �̻��� ���� �Ŵ����� �����մϴ�!");
            Destroy(gameObject);
        }
    }

    public void AddScore(int newScore)
    {
        if (!isGameover)
        {
            score += newScore;
            scoreText.text = "Score: " + score;
        }
    }
  
}*/
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Text scoreText;
    public GameObject successCanvas; // ���� �޽����� ǥ���� ĵ���� ������Ʈ
    private int score = 0;
    private bool isGameover = false;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.LogWarning("���� �� �� �̻��� ���� �Ŵ����� �����մϴ�!");
            Destroy(gameObject);
        }
    }

    public void AddScore(int newScore)
    {
        if (!isGameover)
        {
            score += newScore;
            scoreText.text = "Score: " + score;

            // ���� ������ 10���� �����ϸ� ���� �޽����� ǥ���ϰ� ������ ����ϴ�.
            if (score >= 1)
            {
                ShowSuccessMessage();
            }
        }
    }

    void ShowSuccessMessage()
    {
        // ���� �޽����� ǥ���ϱ� ���� ���� �޽����� ���� UI ĵ������ Ȱ��ȭ�մϴ�.
        successCanvas.SetActive(true);
        // ������ �����մϴ�.
        Time.timeScale = 0f;
    }
}
