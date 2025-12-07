using UnityEngine;
using UnityEngine.SceneManagement;

public class AR_Ui : MonoBehaviour
{
    public GameObject PopupSettings; 
    public GameObject InformationPanel; // PANEL INFO YANG MAU DI ON/OFF

    // Tombol Back
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // Tombol Settings
    public void OpenSettings()
    {
        if (PopupSettings != null)
            PopupSettings.SetActive(true);
        else
            Debug.LogError("PopupSettings belum di-assign di Inspector!");
    }

    // ✅ TOMBOL INFORMATION (TOGGLE ON / OFF)
    public void ToggleInformation()
    {
        if (InformationPanel != null)
        {
            bool isActive = InformationPanel.activeSelf;
            InformationPanel.SetActive(!isActive); // dibalik: ON jadi OFF, OFF jadi ON
        }
        else
        {
            Debug.LogError("InformationPanel belum di-assign di Inspector!");
        }
    }
}
