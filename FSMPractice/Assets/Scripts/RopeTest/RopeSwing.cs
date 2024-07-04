using UnityEngine;

public class RopeSwing : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    public float swingForce = 10f;
    public float climbSpeed = 5f;

    private HingeJoint hingeJoint;
    private bool isClimbing = false;

    void Start()
    {
        // Get the HingeJoint component
        hingeJoint = GetComponent<HingeJoint>();
        hingeJoint.connectedBody = playerRigidbody;
        hingeJoint.useSpring = false;

        // Configure the spring
        JointSpring spring = new JointSpring();
        spring.spring = 10f;
        spring.damper = 1f;
        hingeJoint.spring = spring;
    }

    void Update()
    {
        // Toggle climbing mode
        if (Input.GetKeyDown(KeyCode.E))
        {
            isClimbing = !isClimbing;
        }

        if (isClimbing)
        {
            float vertical = Input.GetAxis("Vertical");
            playerRigidbody.velocity = new Vector3(playerRigidbody.velocity.x, vertical * climbSpeed, playerRigidbody.velocity.z);
        }

        // Swing the rope
        float horizontal = Input.GetAxis("Horizontal");
        playerRigidbody.AddForce(Vector3.right * horizontal * swingForce);
    }
}
