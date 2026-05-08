using UnityEngine;

public class PuzzlePiece2 : MonoBehaviour
{
    public AudioSource source;
    public AudioClip soundEffect;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            source.PlayOneShot(soundEffect);
            FindObjectOfType<Puzzle2Manager>().CollectPiece(gameObject);
        }
    }
}
