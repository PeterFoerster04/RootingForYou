using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int quantity;
    public List<GameObject> spawnPool;
    public GameObject spawnArrea;
    [HideInInspector]public MeshCollider _collider;
	private GameObject spawn;


	Vector2 pos;
    float spawnerX;
    float spawnerY;

    void Start()
    {
		_collider = spawnArrea.GetComponent<MeshCollider>();
		InvokeRepeating("SpawnObstacles", 2f, 2f);
    }

    public void SpawnObstacles()
    {
        int randomObstacle;
 
        

        for (int i = 0; i < quantity; i++)
        {
            randomObstacle = Random.Range(0, spawnPool.Count);
            spawn = spawnPool[randomObstacle];
          

            spawnerX = Random.Range(_collider.bounds.min.x, _collider.bounds.max.x); 
            spawnerY = Random.Range(_collider.bounds.min.y, _collider.bounds.max.y);

            pos = new Vector2(spawnerX, spawnerY);


            int randomInt = Random.Range(0,10);


            if(randomInt<7)
            {
				Instantiate(spawn, pos, spawn.transform.rotation);
   
			}
         
        }
    }
}
