using UnityEngine;

public class CheckForPlayer : MonoBehaviour
{
    public Transform player;
    public float detectionRange = 5f;
    public float fieldOfViewAngle = 90f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 directionToPlayer = player.position - transform.position;
        float distance = directionToPlayer.magnitude;

        if (distance <= detectionRange)
        {
            float angle = Vector3.Angle(transform.forward, directionToPlayer);

            if (angle <= fieldOfViewAngle / 2f)
            {
                Debug.Log("Player detected in front!");
            }
        }
    }
}
