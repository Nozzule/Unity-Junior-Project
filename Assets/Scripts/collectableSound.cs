using UnityEngine;

public class collectableSound : MonoBehaviour
{
    public AudioSource src;
    public AudioClip collectSFX;

    public void collect()
    {
        src.clip = collectSFX;
        src.Play();
    }
}
