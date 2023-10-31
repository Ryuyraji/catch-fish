/*using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;  // 싱글톤 패턴을 사용하여 GameManager 인스턴스에 접근합니다.
    public Text scoreText; // 점수를 출력할 UI 텍스트
    private int score = 0; // 게임 점수
    private bool isGameover = false; // 게임 오버 상태 여부
    
   

    private void Awake()
    {
        // GameManager의 인스턴스를 설정합니다.
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.LogWarning("씬에 두개 이상의 게임 매니저가 존재합니다!");
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
    public GameObject successCanvas; // 성공 메시지를 표시할 캔버스 오브젝트
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
            Debug.LogWarning("씬에 두 개 이상의 게임 매니저가 존재합니다!");
            Destroy(gameObject);
        }
    }

    public void AddScore(int newScore)
    {
        if (!isGameover)
        {
            score += newScore;
            scoreText.text = "Score: " + score;

            // 만약 점수가 10점에 도달하면 성공 메시지를 표시하고 게임을 멈춥니다.
            if (score >= 1)
            {
                ShowSuccessMessage();
            }
        }
    }

    void ShowSuccessMessage()
    {
        // 성공 메시지를 표시하기 전에 성공 메시지를 담은 UI 캔버스를 활성화합니다.
        successCanvas.SetActive(true);
        // 게임을 정지합니다.
        Time.timeScale = 0f;
    }
}
