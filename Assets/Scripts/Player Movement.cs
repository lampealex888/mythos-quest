using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;  // Adjust the speed as needed

    private CharacterController controller;

    void Start()
    {
        // Get the CharacterController component attached to the GameObject
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Get input from the player
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the movement direction based on input
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        // If there is input, move the player
        if (movement.magnitude >= 0.1f)
        {
            // Calculate the desired movement direction in world space
            float targetAngle = Mathf.Atan2(movement.x, movement.z) * Mathf.Rad2Deg + Camera.main.transform.eulerAngles.y;
            Vector3 moveDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;

            // Move the player using CharacterController
            controller.Move(moveDirection.normalized * speed * Time.deltaTime);
        }
    }
}
