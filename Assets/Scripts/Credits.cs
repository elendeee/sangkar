using UnityEngine;

public class Credits : MonoBehaviour
{
    public GameObject creditsPanel;

    void Start()
    {
        creditsPanel.SetActive(false);
    }

    public void OpenCredits()
    {
        creditsPanel.SetActive(true);
    }

    public void CloseCredits()
    {
        creditsPanel.SetActive(false);
    }
}
