using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    public Slider slider;
    public AudioSource audioSource;

    void Start()
    {
        if (slider != null && audioSource != null)
        {
            slider.value = audioSource.volume;  // Set posisi awal slider
            slider.onValueChanged.AddListener(ChangeVolume);
        }
    }

    public void ChangeVolume(float value)
    {
        if (audioSource != null)
            audioSource.volume = value;   // Set volume sesuai slider
    }
}
