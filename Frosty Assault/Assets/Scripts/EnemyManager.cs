using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject Elves;
    public GameObject Chicken;
    private int random;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        random = Random.Range(1, 3);
        if (random == 1)
        {
            if (gameObject.tag == "ChickenSpawner")
            {
                Instantiate(Chicken, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), new Quaternion(0, 0, 0, 0));
            }
            else
            {
                Instantiate(Elves, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), new Quaternion(0, 0, 0, 0));
            }
        }

    }
}