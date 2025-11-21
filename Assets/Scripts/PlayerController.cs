using UnityEngine;
public class PlayerController : MonoBehaviour
{
    private float speed = 150.0f;
    private const float turnSpeed = 45.0f;
    public float rotationSpeed = 100.0f;
    public float baseHeight = 0.5f;
    private float horizontalInput;
    private float forwardInput;
    private float liftInput;

    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        liftInput = Input.GetAxis("Lift");

        bool isGrounded = false;
        int groundLayerMask = LayerMask.GetMask("Ground");

        if (Physics.Raycast(transform.position, Vector3.down, out RaycastHit hit, baseHeight + 0.1f, groundLayerMask))
        {
            isGrounded = true;

            if (liftInput < 0)
            {
                liftInput = 0;
            }

            float groundY = hit.point.y + baseHeight;
            transform.position = new Vector3(transform.position.x, groundY, transform.position.z);
        }

        if (!isGrounded || liftInput > 0)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
            transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        }

        transform.Translate(Vector3.up * Time.deltaTime * speed * liftInput, Space.World);
        transform.Rotate(Vector3.right, Time.deltaTime * rotationSpeed * liftInput);
    }
}