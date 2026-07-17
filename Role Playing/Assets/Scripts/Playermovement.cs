using UnityEngine;

public class Playermovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 5f;
    public float jumpHeight = 1.5f;
    public float gravity = -20f;
    private CharacterController controller;
    private float verticalVelocity;




    
    
    void Start()

    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxisRaw("Horizontal");
        float zInput = Input.GetAxisRaw("Vertical");
        Vector3 moveDirection = transform.right * xInput + transform.forward * zInput;
        moveDirection = Vector3.ClampMagnitude(moveDirection, 1f);




        
        
        if (controller.isGrounded && verticalVelocity<0f)
        {
            verticalVelocity = -2f;
        }
        if (controller.isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            verticalVelocity = Mathf.Sqrt(jumpHeight * -2f * gravity);
            

        }
        verticalVelocity += gravity * Time.deltaTime;
        Vector3 velocity = moveDirection * speed;
        velocity.y = verticalVelocity;
        controller.Move(velocity * Time.deltaTime);

    }

}
