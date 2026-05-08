using UnityEngine;

public class KeypadManager : MonoBehaviour
{
    public string correctCode = "1812";
    private string currentInput = "";
    public GameObject PuzzleDoor;
    public GameObject Puzzle1;
    public int incorrectCount = 0;
    public GameObject GOTrigger;
    public GameObject Player;
    public AudioSource source;
    public AudioClip buttonSound;
    public AudioClip correctSound;
    public AudioClip wrongSound;

    public void Press(string value)
    {
        source.PlayOneShot(buttonSound);

        if (value == "C")
        {
            currentInput = "";
        }
        else if (value == "E")
        {
            CheckCode();
            return;
        }
        else
        {
            currentInput += value;
        }

        Debug.Log("Current Input: " + currentInput);
    }

    void CheckCode()
    {
        if (currentInput == correctCode)
        {
            Debug.Log("Correct! Puzzle solved.");
            source.PlayOneShot(correctSound);
            SolvePuzzle();
        }
        else
        {
            Debug.Log("Wrong code.");
            currentInput = "";
            source.PlayOneShot(wrongSound);
            incorrectCount ++;
            SpawnTrigger();
        }
    }

    public void SpawnTrigger()
    {
        if (incorrectCount == 3)
        {
            //ActiveTrigger();
            GOTrigger.transform.position = Player.transform.position;
            Debug.Log("Game Over");
        }
    }

    void SolvePuzzle()
    {
        Destroy(Puzzle1);
    }
}
