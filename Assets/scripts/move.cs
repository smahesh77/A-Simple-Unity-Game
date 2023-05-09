using UnityEngine;

public class move : MonoBehaviour
{
    public Rigidbody rb;
    public float sideways;
    public void left()
    {
        rb.AddForce(-sideways, 0, 0, ForceMode.VelocityChange);
        Debug.Log("left clicked");
    }
    public void right()
    {
        rb.AddForce(sideways, 0, 0, ForceMode.VelocityChange);
    }
}
