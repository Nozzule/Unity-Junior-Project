using UnityEngine;

public class GOTrigger : MonoBehaviour
{
    public GameObject canvasToToggle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        canvasToToggle.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canvasToToggle.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
