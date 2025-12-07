using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public static SFXManager Instance;

    [Range(0f, 1f)]
    public float sfxVolume = 1f;

    public AudioSource uiSFX;   // <-- ini tambahan untuk UI button

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetSFXVolume(float vol)
    {
        sfxVolume = vol;

        // update volume button
        if (uiSFX != null)
            uiSFX.volume = vol;
    }

    public void PlayUI()
    {
        if (uiSFX != null)
        {
            uiSFX.volume = sfxVolume;
            uiSFX.Play();
        }
    }
}