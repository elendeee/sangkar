using UnityEngine;
using UnityEngine.SceneManagement;

public class AR_Ui : MonoBehaviour
{
    public GameObject PopupSettings; // WAJIB kapital P sesuai nama prefab

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
    public void OpenSettings()
    {
        if (PopupSettings != null)
            PopupSettings.SetActive(true);
        else
            Debug.LogError("PopupSettings belum di-assign di Inspector!");
    }
}
