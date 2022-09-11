using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{       

    public CharacterController controller;
    public float moveSpeed = 12f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   // Get User Input
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
         // Move player with respect to taken input from x and z axes
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * moveSpeed * Time.deltaTime);
        // Increase gravity force by 9.8 when falling
       
    }
}
