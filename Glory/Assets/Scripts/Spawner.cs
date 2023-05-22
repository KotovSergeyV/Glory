using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;
    [SerializeField] private float random;
    Vector3 whereToSpawn;
    [SerializeField] private float spawnDelay;
    [SerializeField] private float nextSpawn = 0.0f ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time>nextSpawn)
        {
            nextSpawn = Time.time + spawnDelay;
            random = Random.Range(208,160);
            whereToSpawn = new Vector3(random, transform.position.y);
        }
    }
}
