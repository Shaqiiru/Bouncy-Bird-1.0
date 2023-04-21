using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCloud : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cloud;
	private float timeBtwSpawn;
	public float StartTimeBtwSpawn;
    private Vector3 SpawnPos;
    float yPos;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        yPos = Random.Range(2.51f, -2.59f);
        SpawnPos = new Vector3(13.78f, yPos, transform.position.z);
        
        if(timeBtwSpawn <= 0)
        {
        	Instantiate(cloud, SpawnPos, transform.rotation);
        	timeBtwSpawn = StartTimeBtwSpawn;
        }
        else
        {
        	timeBtwSpawn -= Time.deltaTime;

        }
    }
}
