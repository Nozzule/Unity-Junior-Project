using UnityEngine;

public class AttachRenderer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MeshRenderer myRenderer = gameObject.AddComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
