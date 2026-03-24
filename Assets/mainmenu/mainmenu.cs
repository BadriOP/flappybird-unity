using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public GameObject aboutPanel;

    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ShowAbout()
    {
        aboutPanel.SetActive(true);
    }

    public void HideAbout()
    {
        aboutPanel.SetActive(false);
    }
}