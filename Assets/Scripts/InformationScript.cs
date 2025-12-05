using UnityEngine;

public class InformationScript : MonoBehaviour
{
    public GameObject InformationPanel;

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
}
