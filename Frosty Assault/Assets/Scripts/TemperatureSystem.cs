using System;
using UnityEngine;

public class TemperatureSystem : MonoBehaviour
{
    public float decayRate = 1.0f;
    private float temperature;
    private string gameStatus;
    private bool fire;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        temperature = 100.0f;
        gameStatus = "In Progress";
        fire = false;
    }

    // Update is called once per frame
    void Update()
    {
        if ( gameStatus == "In Progress")
        {
            temperature = temperature - (decayRate * Time.deltaTime);
        }
        if ( fire == true )
        {
            temperature = temperature - (decayRate * Time.deltaTime * 3);
        }
        if ( temperature <= 0 && gameStatus == "In Progress")
        {
            gameStatus = "Lose";
            Debug.Log("Game over, you lose.");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if ( collision.gameObject.tag == "Ice" )
        {
            temperature = 100.0f;
            Destroy(collision.gameObject);
        }
        if ( collision.gameObject.tag == "End" && gameStatus == "In Progress" )
        {
            gameStatus = "End";
            Debug.Log("Congratulations, you win!");
            Destroy(collision.gameObject);
        }
        if ( collision.gameObject.tag == "Chicken")
        {
            fire = true;
        }
        if (collision.gameObject.tag == "Elf")
        {
            gameStatus = "Lose";
            Debug.Log("Game over, you lose.");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if ( collision.gameObject.tag == "Chicken")
        {
            fire = false;
        }
    }
}