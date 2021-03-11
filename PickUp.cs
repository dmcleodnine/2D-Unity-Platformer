using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
     GameManager manny;

    // Start is called before the first frame update
    void Start()
    {
        manny = (GameManager)FindObjectOfType(typeof(GameManager));
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Player") 
        {
            manny.highScore ++;
            Destroy(gameObject);
        }
    }
}
