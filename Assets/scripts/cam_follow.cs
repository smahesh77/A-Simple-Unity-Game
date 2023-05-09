using UnityEngine;

public class cam_follow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public movement m;
    public Transform ball;
    public bool selbox = false, selball = false;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;

    }
}
