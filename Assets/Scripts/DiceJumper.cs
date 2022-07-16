using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceJumper : MonoBehaviour
{
    float horizontalInput, verticalInput;
    public float moveSpeed = 10f;
    public float jumpForce = 2.0f;
    Vector3 jumpDirection = new Vector3(0.0f, 5.0f);
    Rigidbody rb;
    [SerializeField] float distanceToCheck = 0.5f;
    [SerializeField] bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(Physics.Raycast(transform.position, Vector3.down, distanceToCheck)) 
        {
            isGrounded = true;
        }
        else 
        {
            isGrounded = false;
        }

        if (isGrounded) 
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                JumpNRoll();
            }
        }
    }

    private void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput);

        if (isGrounded) 
        {
            rb.AddForce(movement * moveSpeed);
        }
    }

    void JumpNRoll() // The die can now jump, now to actually get a result
    {
        rb.AddForce(jumpDirection * jumpForce, ForceMode.Impulse);
    }
}
