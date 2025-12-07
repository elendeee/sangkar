using UnityEngine;
using TMPro;
using Vuforia;

public class MarkerInfo : MonoBehaviour
{
    [TextArea(3, 5)]
    public string infoText;              // teks khusus marker ini

    public GameObject infoPanel;         // panel global
    public TMP_Text infoTextUI;          // text TMP pada panel

    [TextArea(3, 5)]
    public string defaultText = "";      // text default saat marker tidak terscan

    private ObserverBehaviour observer;

    void Start()
    {
        observer = GetComponent<ObserverBehaviour>();

        if (observer != null)
            observer.OnTargetStatusChanged += OnStatusChanged;
    }

    private void OnStatusChanged(ObserverBehaviour behaviour, TargetStatus status)
    {
        bool detected =
            status.Status == Status.TRACKED ||
            status.Status == Status.EXTENDED_TRACKED;

        if (detected)
        {
            // Saat marker TERSCAN → isi teks sesuai marker
            infoTextUI.text = infoText;
            infoPanel.SetActive(true);
        }
        else
        {
            // Saat marker HILANG → reset kembali default
            infoTextUI.text = defaultText;
            infoPanel.SetActive(false); // atau tetap tampil, terserah kamu
        }
    }
}