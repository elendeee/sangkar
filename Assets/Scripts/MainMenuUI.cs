using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public Credits creditsPopup;

    // Tombol START AR
    public void StartAR()
    {
        SceneManager.LoadScene("AR");
    }

    // Tombol SETTINGS
    public void OpenSettings()
    {
        SceneManager.LoadScene("Settings");
    }

    // Tombol CREDITS
    public void OpenCredits()
    {
        creditsPopup.OpenCredits();
    }

    // Tombol QUIT
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Quit"); // Ini hanya kelihatan di Editor
    }
}
