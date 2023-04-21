using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpanwScene : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Scenery;
	private float timeBtwSpawn;
	public float StartTimeBtwSpawn;
	private Vector3 SpawnPos;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnPos = new Vector3(23.76f, 0.9750288f, transform.position.z);

        if(timeBtwSpawn <= 0)
        {
        	Instantiate(Scenery, SpawnPos, transform.rotation);
        	timeBtwSpawn = StartTimeBtwSpawn;
        }
        else
        {
        	timeBtwSpawn -= Time.deltaTime;

        }

    }
}
