using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyAi : MonoBehaviour
{
    private string enemyType;
    public GameObject player;
    public float moveSpeed;
    private float playerDistance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemyType = gameObject.tag;
        player = GameObject.Find("Player").transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        playerDistance = Vector3.Distance(gameObject.transform.position, player.gameObject.transform.position);
        if ( enemyType == "Chicken" )
        {
            if ( playerDistance <= 75 )
            {
                Vector3 directionToMove = player.transform.position - gameObject.transform.position;
                directionToMove = directionToMove.normalized * Time.deltaTime * moveSpeed;
                transform.position = gameObject.transform.position + Vector3.ClampMagnitude(directionToMove, moveSpeed);
                
            }
        }
    }
}