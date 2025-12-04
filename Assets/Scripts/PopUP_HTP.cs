using UnityEngine;

public class PopUP_HTP : MonoBehaviour
{
    public GameObject popupPanel;   // Panel popup

    void Start()
    {
        popupPanel.SetActive(true);   // Popup otomatis muncul saat masuk scene
    }

    public void StartScan()
    {
        popupPanel.SetActive(false);  // Popup langsung hilang saat tombol diklik
    }
}
