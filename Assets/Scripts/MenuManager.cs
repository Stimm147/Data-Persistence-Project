using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public InputField nameInputField;

    public void StartGame()
    {
        if (nameInputField != null && !string.IsNullOrEmpty(nameInputField.text))
        {
            GameManager.instance.SetPlayerName(nameInputField.text);
            SceneManager.LoadScene(0);
        }
    }
    
}
