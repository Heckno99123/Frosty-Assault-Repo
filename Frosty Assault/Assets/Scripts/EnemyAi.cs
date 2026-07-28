using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyAi : MonoBehaviour
{
    public GameObject Chicken;
    public GameObject Elves;
    private float Enemy = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Awake()
    {
        Player = GameObject.Find("player").transform;
        

    }
}
