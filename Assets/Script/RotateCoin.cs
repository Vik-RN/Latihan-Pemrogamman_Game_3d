using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        transform.Rotate(0, 1, 0, Space.Self);
        transform.Rotate(0, 1, 0, Space.World);
    }
}
