using UnityEngine;

public class EndingTrigger : MonoBehaviour
{
    public GameObject canvasToToggle;

    public void Start()
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
