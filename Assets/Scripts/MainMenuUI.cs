using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public Credits creditsPopup;
    public GameObject PopupSettings; // WAJIB kapital P sesuai nama prefab

    // Tombol START AR
    public void StartAR()
    {
        SceneManager.LoadScene("AR");
    }

    // Tombol SETTINGS (MUNCULKAN POPUP, BUKAN PINDAH SCENE)
    public void OpenSettings()
    {
        if (PopupSettings != null)
            PopupSettings.SetActive(true);
        else
            Debug.LogError("PopupSettings belum di-assign di Inspector!");
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
        Debug.Log("Game Quit"); // hanya kelihatan di Editor
    }
}
