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

    public void Press(string value)
    {
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
            SolvePuzzle();
        }
        else
        {
            Debug.Log("Wrong code.");
            currentInput = "";
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

    //public void ActiveTrigger()
    //{
        //GOTrigger.transform.position = Player.transform.position;
    //}

    void SolvePuzzle()
    {
        Destroy(Puzzle1);
    }
}
