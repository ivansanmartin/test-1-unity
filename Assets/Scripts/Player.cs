using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Player : MonoBehaviour
{
    public float speed = 2f;
    public float sensibilidad = 5f;
    public Vector3 turn;
    public Rigidbody rb;

    private void Awake()
    {

        rb = GetComponent<Rigidbody>();
        

        
    }

    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        float moveJump = Input.GetAxis("Jump");

        Vector3 movement = new Vector3( moveHorizontal, moveJump, moveVertical) * (Time.deltaTime * speed); 

        transform.Translate(movement);
        
        turn.x += Input.GetAxis("Mouse X") * sensibilidad;
        turn.y += Input.GetAxis("Mouse Y") * sensibilidad;

        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);

      


    }

    // Update is called once per frame

}
