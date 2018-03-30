using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{

	private void Start()
	{
        Debug.Log("Called");
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
        if (collision.collider.tag == ("Cactus"))
        {
            Debug.Log("hit");
            gameOver();

        }
        else{
            Debug.Log("Collision- not cactus");
        }
	}

    void gameOver()
    {
        
        print("game over");
    }

}
  