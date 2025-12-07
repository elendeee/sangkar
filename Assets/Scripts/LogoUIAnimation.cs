using UnityEngine;

public class LogoUIAnimationCanvas : MonoBehaviour
{
    [Header("Target Logo")]
    public RectTransform logo;   // drag Image Logo ke sini

    [Header("Intro Animation")]
    public float introSpeed = 6f;

    [Header("Idle Pulse")]
    public float pulseSpeed = 2f;
    public float pulseScale = 0.04f;

    Vector3 normalScale;
    bool introDone = false;

    void Start()
    {
        if (logo == null)
        {
            Debug.LogWarning("Logo belum di-assign di Inspector!");
            return;
        }

        normalScale = logo.localScale;
        logo.localScale = Vector3.zero; // mulai dari kecil
    }

    void Update()
    {
        if (logo == null) return;

        // === ANIMASI MASUK (POP-UP) ===
        if (!introDone)
        {
            logo.localScale = Vector3.Lerp(
                logo.localScale,
                normalScale * 1.1f,   // efek mantul dikit
                Time.deltaTime * introSpeed
            );

            if (Vector3.Distance(logo.localScale, normalScale) < 0.05f)
            {
                logo.localScale = normalScale;
                introDone = true;
            }
        }
        // === ANIMASI IDLE (DENYUT) ===
        else
        {
            float pulse = 1 + Mathf.Sin(Time.time * pulseSpeed) * pulseScale;
            logo.localScale = normalScale * pulse;
        }
    }
}
