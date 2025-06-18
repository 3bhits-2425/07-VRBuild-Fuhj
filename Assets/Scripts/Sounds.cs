using UnityEngine;

public class PlaySoundOnTrigger : MonoBehaviour
{
    [Header("Drag the AudioClip here in Inspector")]
    public AudioClip soundClip;  // Das ziehst du im Inspector rein

    private AudioSource audioSource;

    private void Start()
    {
        // Fügt automatisch einen AudioSource-Komponente hinzu
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = soundClip;
        audioSource.playOnAwake = false;
        audioSource.spatialBlend = 1.0f; // 3D Sound
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera")) // XR Rig Kamera muss "MainCamera"-Tag haben
        {
            audioSource.Play();
        }
    }
}
