using UnityEngine;

public class ReproducirAudio : MonoBehaviour
{
    public AudioSource audioSource;

    private void Start()
    {
        // Reproducir el audio
        audioSource.Play();
    }
}

