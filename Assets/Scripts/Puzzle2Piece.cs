using UnityEngine;

public class PuzzlePiece2 : MonoBehaviour
{
    private bool collected = false;

    private void OnTriggerEnter(Collider other)
    {
        if (collected) return;

        if (other.CompareTag("Player"))
        {
            collected = true;

            GetComponent<Collider>().enabled = false;

            FindFirstObjectByType<Puzzle2Manager>().CollectPiece(gameObject);
        }
    }
}
