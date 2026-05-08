using UnityEngine;

public class PuzzlePiece2 : MonoBehaviour
{
    private bool collected = false;

    //public AudioSource source;
    //public AudioClip soundEffect;

    private void OnTriggerEnter(Collider other)
    {
        if (collected) return;

        if (other.CompareTag("Player"))
        {
            collected = true;

            GetComponent<Collider>().enabled = false;

            //source.PlayOneShot(soundEffect);

            FindObjectOfType<Puzzle2Manager>().CollectPiece(gameObject);
        }
    }
}
