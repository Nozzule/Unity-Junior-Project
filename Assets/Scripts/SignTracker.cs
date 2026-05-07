using UnityEngine;

public class SignTracker : MonoBehaviour
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
        ExitSign();
    }

    void OnMouseDown()
    {
        if (CompareTag("Sign"))
        {
            canvasToToggle.SetActive(true);
        }
    }

    void ExitSign()
    {
        if (Input.GetKeyDown(interactionKey))
        {
            canvasToToggle.SetActive(false);
        }
    }
}
