using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{

    public static bool gameOver = false;

	private void Start()
	{
        Debug.Log("Called");
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
        if (collision.collider.tag == ("Cactus"))
        {
            Debug.Log("hit");
            gameOverFunc();

        }
        else{
            Debug.Log("Collision- not cactus");
        }
	}

    void gameOverFunc()
    {
        print("game over");
        gameOver = true;
    }

}
  