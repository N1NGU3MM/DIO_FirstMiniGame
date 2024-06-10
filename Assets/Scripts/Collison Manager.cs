using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
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
       if (!GameManager.Instance.isGameActive)
        {
            return;
        }
        //  Check if other object is a ball
        if ( other.gameObject.CompareTag("Ball"))
        {
            // Increment Score
            GameManager.Instance.score++;
            Debug.Log($"Score {GameManager.Instance.score}");
            
            // Destroy onbject
            Destroy(other.gameObject);
        }

    }
}
