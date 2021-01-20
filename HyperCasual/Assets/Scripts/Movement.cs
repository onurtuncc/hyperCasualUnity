using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    CharacterController characterController;
    float speed=12f;
    float gravity = 15f;
    Vector3 moveVector;
    Animator animator;
    float verticalVelocity = 0f;
    public bool inBossFight = false;
    void Start()
    {
        animator = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!inBossFight)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                characterController.Move(Vector3.right * 3);

            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                characterController.Move(Vector3.left * 3);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                characterController.height = 1;
            }
            if (Input.GetKeyUp(KeyCode.S))
            {
                animator.SetTrigger("slideTrigger");
                characterController.height = 2;
            }
            moveVector.z = speed;
            if (characterController.isGrounded)
            {
                

                if (Input.GetKey(KeyCode.Space))
                {
                    animator.SetTrigger("jumpTrigger");
                    verticalVelocity = 8f;
                }
                else
                {
                    verticalVelocity = 0f;
                }

            }
            else
            {
                // Apply gravity
                verticalVelocity -= gravity * Time.deltaTime;
            }
            moveVector.y = verticalVelocity;
            characterController.Move(moveVector * Time.deltaTime);
        }
        
        
        

    }
    public void BossFightState()
    {
        inBossFight = true;
        animator.SetBool("isInBossFight", inBossFight);
    }
}
