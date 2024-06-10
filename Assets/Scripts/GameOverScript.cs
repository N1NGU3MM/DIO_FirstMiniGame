using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter(Collision other)
    {
       
        //  Check if other object is a ball
        
        
        if (other.gameObject.CompareTag("Ball"))
        {
            
            //  Print menssage
            Debug.Log("Game Over");

             // Destroy onbject
            Destroy(other.gameObject);

            // End Game
            GameManager.Instance.isGameActive = false;
        }
    }

}
