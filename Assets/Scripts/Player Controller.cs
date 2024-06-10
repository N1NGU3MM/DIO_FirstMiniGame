using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   

    public float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (!GameManager.Instance.isActiveAndEnabled)
        {
            return;
        }
        // transform.position += new Vector3(1,0, 0);

        //  Get Input valume 
        bool isPressingLeft = Input.GetKey(KeyCode.A);
        bool isPressingRight = Input.GetKey(KeyCode.D);
        // Debug.Log($"Left: {isPressingLeft}, Right {isPressingRight}");
        

        // Aborrt if no key are pressed, ar booth are pressed at the same time
        if (isPressingLeft == isPressingRight)
        {
            return;
        } 

        //  Move player
        float movement = speed * Time.deltaTime;
        if(isPressingLeft)
        {
            movement *= -1f; 
        }

        transform.position += new Vector3(movement, 0, 0);

        //  limit player
        var movementLimit = GameManager.Instance.gameWidth / 2;
        if( transform.position.x < -movementLimit)
        {
            transform.position = new Vector3(-movementLimit, transform.position.y, transform.position.z);
        } 
        else if (transform.position.x > movementLimit) 
        {
            transform.position = new Vector3(movementLimit, transform.position.y, transform.position.z);
        }

    }
}
