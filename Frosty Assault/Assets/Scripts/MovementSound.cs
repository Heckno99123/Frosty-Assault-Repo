using UnityEngine;

public class MovementSound : MonoBehaviour
{
    public float movementThreshold = 0.1f; // Minimum speed to trigger sound
    public bool useCharacterController = true; // Toggle based on movement system

    private AudioSource audioSource;
    private CharacterController characterController;
    private Rigidbody rb;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = true;
        if (useCharacterController)
        {
            characterController = GetComponent<CharacterController>();
        }
        else
        {
            rb = GetComponent<Rigidbody>();
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float speed = 0f;
        if (useCharacterController && characterController != null)
        {
            speed = characterController.velocity.magnitude;
        }
        else if (rb != null)
        {
            speed = rb.linearVelocity.magnitude;
        }
        if (speed > movementThreshold)
        {
            if (!audioSource.isPlaying)
                audioSource.Play();
        }
        else
        {
            if (audioSource.isPlaying)
                audioSource.Stop();
        }
    }
}
