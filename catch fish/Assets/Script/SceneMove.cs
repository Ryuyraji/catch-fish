using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour
{
    //public string SceneName;

    public void Open()
    {
        SceneManager.LoadScene(1);
        //Debug.Log(SceneName);
    }
}
