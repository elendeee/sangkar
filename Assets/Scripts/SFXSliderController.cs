using UnityEngine;
using UnityEngine.UI;

public class SFXSliderController : MonoBehaviour
{
    public Slider sfxSlider;

    void Start()
    {
        sfxSlider.value = SFXManager.Instance.sfxVolume;

        sfxSlider.onValueChanged.AddListener((v) => {
            SFXManager.Instance.SetSFXVolume(v);
        });
    }
}