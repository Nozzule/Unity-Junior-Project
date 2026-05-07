using UnityEngine;

public class BookTracker : MonoBehaviour
{
    public GameObject canvasToToggle;
    public KeyCode interactionKey;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        canvasToToggle.SetActive(false);
    }

    void Update()
    {
        ExitBook();
    }

    void OnMouseDown()
    {
        if (CompareTag("Book"))
        {
            canvasToToggle.SetActive(true);
        }
    }

    void ExitBook()
    {
        if (Input.GetKeyDown(interactionKey))
        {
            canvasToToggle.SetActive(false);
        }
    }
}
