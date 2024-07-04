using UnityEngine;

public class RopeSegment : MonoBehaviour
{
    public Rigidbody connectedRigidbody;

    void Start()
    {
        if (connectedRigidbody != null)
        {
            HingeJoint hingeJoint = gameObject.AddComponent<HingeJoint>();
            hingeJoint.connectedBody = connectedRigidbody;
            hingeJoint.useLimits = true;

            JointLimits limits = new JointLimits();
            limits.min = -45f;
            limits.max = 45f;
            hingeJoint.limits = limits;
        }
    }
}
