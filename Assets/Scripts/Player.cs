using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private bool jumpKeyWasPressed;
    private float _speed = 4f;
    private bool aKeyWasPressed;
    private float horizontalInput;
    public float Speed = 5f;
    public bool canControl;
    public GameObject Character;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Check if space key is pressed down   
       if (Input.GetKey(KeyCode.Space))
        {
            jumpKeyWasPressed = true;
            


        }
       
        

  
    }
    void CalculateMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);

        transform.Translate(direction * _speed * Time.deltaTime);
    }

    // FixedUpdate is called once every physic update
    private void FixedUpdate()
    {
        if (jumpKeyWasPressed)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 5, ForceMode.VelocityChange);
            jumpKeyWasPressed = false;

        
        }
      
        

    }

    

}       
