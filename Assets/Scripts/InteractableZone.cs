using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class InteractableZone : MonoBehaviour
{
    private int priority = 0;

    private string promptText = "[E] Interact";

    public UnityEvent<GameObject> onInteract;

    public int Priority => priority;

    public string Prompt => promptText;

    public void Interact(GameObject interactor)
    {
        onInteract?.Invoke(interactor);
    }

    private void Reset()
    {
        Collider col = GetComponent<Collider>();
        col.isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerInteractionController player = other.GetComponent<PlayerInteractionController>();

        if (player != null)
        {
            player.RegisterZone(this);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PlayerInteractionController player = other;
        if (player != null)
        {
            player.UnregisterZone(this);
        }
    }
}
