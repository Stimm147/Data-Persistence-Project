using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public InputField nameInputField;
    public Text BestScore;

    void Start()
    {
        LoadBestScore();
    }

    public void StartGame()
    {
        if (nameInputField != null && !string.IsNullOrEmpty(nameInputField.text))
        {
            GameManager.instance.SetPlayerName(nameInputField.text);
            SceneManager.LoadScene(0);
        }
    }
    public void Exit()
    {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }
    private void LoadBestScore()
    {
        int bestScore = PlayerPrefs.GetInt("BestScore", 0);
        string bestPlayerName = PlayerPrefs.GetString("BestPlayerName", "None");

        if (BestScore != null)
        {
            BestScore.text = "Best Score: " + bestPlayerName + " : " + bestScore;
        }
    }
    
}
