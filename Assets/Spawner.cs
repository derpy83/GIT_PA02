using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject SpawnObject, SpawnObject2, SpawnObject3, spawnobj4;
    float PositionX;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
        InvokeRepeating("SpawnObjects2", 1, 1);
        InvokeRepeating("SpawnObjects3", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {


    }


    void SpawnObjects()
    {
        PositionX = Random.Range(4, -4f);
        this.transform.position = new Vector3(PositionX, transform.position.y, transform.position.z);
        int i = Random.Range(1, 4);
        GameObject obj;
        if (i > 4)
        {
            obj = SpawnObject;
        }
        else if (i > 3)
        {
            obj = SpawnObject2;
        }
        else if (i > 2)
        {
            obj = SpawnObject3;
        }
        else if (i > 1)
        {
            obj = spawnobj4;
        }
        else
        {
            obj = SpawnObject3;
        }
        Instantiate(obj, transform.position, transform.rotation);
    }
}
