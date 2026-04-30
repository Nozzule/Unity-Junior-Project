using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class PlayerInteractionController : MonoBehaviour
{
    public Camera playerCamera;

    private InputActionReference Interact;

    public bool useLookAtOverride = true;

    public float lookOverrideMaxDistance = 4f;

    public LayerMask lookOverrideLayerMask = 0;

    public bool debugLookRay = false;

    [SerializeField] private readonly List<InteractableZone> zonesInRange = new List<InteractableZone>();

    private InteractableZone currentZone;

    public string CurrentPrompt => currentZone != null ? currentZone.Prompt : string.Empty;

    private void OnEnable()
    {
        if (Interact != null) Interact.action.Enable();

        Interact.action.performed += HandleInput;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateActiveZone();
    }

    private void UpdateActiveZone()
    {
        InteractableZone best = null;
        int bestPriority = int.MinValue;

        foreach (var zone in zonesInRange)
        {
            if (zone == null) continue;
            if (zone.Priority > bestPriority)
            {
                bestPriority = zone.Priority;
                best = zone;
            }

        }

        if (useLookAtOverride && playerCamera != null && zonesInRange.Count > 0)
        {
            Ray ray = playerCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

            if (debugLookRay)
            {
                Debug.DrawRay(ray.origin, ray.direction * lookOverrideMaxDistance, Color.yellow);
            }

            if (Physics.Raycast(ray, out RaycastHit hit, lookOverrideMaxDistance, lookOverrideLayerMask))
            {
                InteractableZone lookedAtZone = hit.collider.GetComponentInParent<InteractableZone>();
                if (lookedAtZone != null && zonesInRange.Contains(lookedAtZone))
                {
                    best = lookedAtZone;
                }
            }
        }

        if (currentZone != best)
        {
            currentZone = best;
        }
    }

    private void HandleInput(InputAction.CallbackContext obj)
    {
        if (currentZone != null)
        {
            currentZone.Interact(gameObject);
        }
    }
}
