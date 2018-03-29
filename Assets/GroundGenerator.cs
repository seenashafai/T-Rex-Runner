using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGenerator : MonoBehaviour {

    public GameObject Ground;

    public int Duplicates = 20;
    public int length = 25;
    public int ScaleFactor = 5;
    public float y = 0.2f;
    public float x = 1.2f; 

	// Use this for initialization
	void Start () {

        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < Duplicates; i++)
        {
            spawnPosition.y = y;
            spawnPosition.x = (x + (i*length));
            Instantiate(Ground, spawnPosition, Quaternion.identity);
        }

		
	}

}
