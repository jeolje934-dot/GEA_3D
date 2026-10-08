using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpPower = 5f;
    public float gravity = -20f;
    public float mouseSensitiviity = 0.2f;
    private Vector2 lookInput;
    public Transform cameraPivot;
    public Transform cameraTransform;
    private bool isRunning;
    public float pitch = 20f;

    private Vector2 moveInput;
    private float verticalVelocity;
    private CharacterController controller;


    void Start()
    {
        controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;

    }

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
    public void OnJump(InputValue value)
    {
        if (value.isPressed && controller.isGrounded)
        {
            verticalVelocity = jumpPower;
        }
    }
    
    public void OnSprint(InputValue value)
    {
        isRunning = value.isPressed;
    }


    public void OnLook(InputValue value)
    {
        lookInput = value.Get<Vector2>();
    }




    void Update()
    {
        transform.Rotate(0f, lookInput.x * mouseSensitiviity, 0f);
        pitch = pitch - lookInput.y * mouseSensitiviity;
        pitch = Mathf.Clamp(pitch, 0f, 0f);


        if (controller.isGrounded && verticalVelocity < 0f)
        {
            verticalVelocity = -2f;
        }

        verticalVelocity += gravity * Time.deltaTime;

        Vector3 move = transform.forward * moveInput.y + transform.right * moveInput.x;


        float speed = moveSpeed;
        float targetZ = -6f;
        if(isRunning)
        {
            speed = moveSpeed * 2f;
            targetZ = -8f;
        }
        move = move * speed;
        move.y = verticalVelocity;

        Vector3 camPos = cameraTransform.localPosition;
        camPos.z = Mathf.Lerp(camPos.z, targetZ, 5f * Time.deltaTime);
        cameraTransform.localPosition = camPos;

        

        controller.Move(move * Time.deltaTime);
    }
}


