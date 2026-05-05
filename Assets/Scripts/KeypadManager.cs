using UnityEngine;

public class KeypadManager : MonoBehaviour
{
    public string correctCode = "1234";
    private string currentInput = "";
    public GameObject PuzzleDoor;

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
        }
    }

    void SolvePuzzle()
    {
        //Destroy(gameObject);
    }
}
