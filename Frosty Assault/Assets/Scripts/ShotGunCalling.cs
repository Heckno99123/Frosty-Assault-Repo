using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class ShotGunCalling : MonoBehaviour
{
    public AudioClip shotgunBlast;
    private AudioSource shotgunAudio;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        shotgunAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            shotgunAudio.PlayOneShot(shotgunBlast, 1.0f);
        }

        
       

      
    }
}
