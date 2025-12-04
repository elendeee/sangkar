using UnityEngine;
using UnityEngine.SceneManagement;

public class AR_Ui : MonoBehaviour
{
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
