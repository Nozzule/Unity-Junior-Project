using UnityEngine;

public class Puzzle2Manager : MonoBehaviour
{
    public GameObject Puzzle2;
    private int puzzle2Piece = 0;
    private bool solved = false;
    //public AudioSource source2;
    //public AudioClip soundEffect;
    public AudioSource src;
    public AudioClip collectSFX;

    public void CollectPiece(GameObject piece)
    {
        src.PlayOneShot(collectSFX);
        Destroy(piece);
        puzzle2Piece++;

        Debug.Log("Item Collected: " + puzzle2Piece);

        if (!solved && puzzle2Piece == 4)
        {
            solved = true;
            SolvePuzzle2();
        }
    }

    void SolvePuzzle2()
    {
        Debug.Log("Puzzle solved");

        foreach (Transform child in Puzzle2.transform)
        {
            Destroy(child.gameObject);
        }
    }
}
