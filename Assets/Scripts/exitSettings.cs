using UnityEngine;

public class exitSettings : MonoBehaviour
{
    public GameObject PopupSettings; // drag prefab Settings dari Hierarchy

    public void ExitSettings()
    {
        PopupSettings.SetActive(false);
    }
}
