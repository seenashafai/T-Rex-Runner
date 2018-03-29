using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusGenerator : MonoBehaviour
{

    public GameObject Cactus;

    public int Duplicates = 20;
    public int Distance = 20;
    public float y = 0.2f;
    public float minX = 1.2f;
    public float maxX = 20f;

    // Use this for initialization
    void Start()
    {

        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < Duplicates; i++)
        {
            spawnPosition.y = y;
            spawnPosition.x = Random.Range(minX, maxX);
            Instantiate(Cactus, spawnPosition, Quaternion.identity);
        }


    }

}
