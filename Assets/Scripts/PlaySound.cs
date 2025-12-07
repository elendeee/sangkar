using UnityEngine;
using Vuforia;

public class PlaySound : MonoBehaviour
{
    public AudioSource narasiAudio;
    public AudioSource sfxAudio;

    private ObserverBehaviour observer;
    private bool hasDetectedOnce = false;

    void Start()
    {
        observer = GetComponent<ObserverBehaviour>();

        if (observer != null)
        {
            observer.OnTargetStatusChanged += OnTargetStatusChanged;
        }
    }

    void Update()
    {
        // Volume SFX SELALU mengikuti Settings
        if (sfxAudio != null)
        {
            sfxAudio.volume = SFXManager.Instance.sfxVolume;
        }
    }

    private void OnTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus status)
    {
        bool detected =
            status.Status == Status.TRACKED ||
            status.Status == Status.EXTENDED_TRACKED;

        if (detected)
        {
            if (!hasDetectedOnce)
                hasDetectedOnce = true;

            if (hasDetectedOnce)
            {
                if (!narasiAudio.isPlaying)
                    narasiAudio.Play();

                if (!sfxAudio.isPlaying)
                    sfxAudio.Play();
            }
        }
        else
        {
            if (narasiAudio.isPlaying)
                narasiAudio.Pause();

            if (sfxAudio.isPlaying)
                sfxAudio.Pause();
        }
    }
}