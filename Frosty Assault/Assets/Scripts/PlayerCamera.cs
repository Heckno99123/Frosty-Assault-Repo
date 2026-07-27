using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        void Start()
        {
            // Optional: Adjust the camera's rotation
            transform.rotation = Quaternion.Euler(20, 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + offset;
    }
}
