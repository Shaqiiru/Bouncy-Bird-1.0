using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
    // Start is called before the first frame update
	public GameObject tree;
	private float timeBtwSpawn;
	public float StartTimeBtwSpawn;
	private Vector3 SpawnPos;
	float xPos;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	xPos = Random.Range(13.31f, 28.18f);
    	SpawnPos = new Vector3(xPos, -2.53f, transform.position.z);

        if(timeBtwSpawn <= 0)
        {
        	Instantiate(tree, SpawnPos, transform.rotation);
        	timeBtwSpawn = StartTimeBtwSpawn;
        }
        else
        {
        	timeBtwSpawn -= Time.deltaTime;

        }
    }
}
