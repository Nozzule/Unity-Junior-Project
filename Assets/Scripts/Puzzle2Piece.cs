using UnityEngine;

public class PuzzlePiece2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<Puzzle2Manager>().CollectPiece(gameObject);
        }
    }
}
