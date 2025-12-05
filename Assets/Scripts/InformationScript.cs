using UnityEngine;

public class InformationScript : MonoBehaviour
{
    public GameObject InformationPanel;
    public AudioSource audioSource;

    void Start()
    {
        if (InformationPanel != null)
            InformationPanel.SetActive(false);
    }

    public void InfoButton()
    {
        if (InformationPanel != null)
        {
            bool isActive = InformationPanel.activeSelf;
            InformationPanel.SetActive(!isActive);
        }
    }

    public void ToggleSound()
    {
        if (audioSource == null) return;

        if (audioSource.isPlaying)
        {
            audioSource.Stop();     // Klik kedua → berhenti
        }
        else
        {
            audioSource.Play();     // Klik pertama & ketiga → bunyi lagi
        }
    }
}
