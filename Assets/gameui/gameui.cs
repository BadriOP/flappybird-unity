using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUIScript : MonoBehaviour
{
    public void QuitGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}