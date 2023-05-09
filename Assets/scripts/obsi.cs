using UnityEngine;

public class obsi : MonoBehaviour
{
    public movement m;
    public Transform player;
    public Vector3 spawn, rot;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("g"))
        {
            m.enabled = true;
            
            player.position = spawn;
            //player.rotation = rot;
        }

        if ((player.position.x > 11 || player.position.x < -11)&&player.position.y<1)
            FindObjectOfType<boss>().Endgame();

    }
    void OnCollisionEnter(Collision c)
    {
        if (c.collider.tag == "obs")
        {
            m.enabled = false;
            FindObjectOfType<boss>().Endgame();
        }
            

    }
}
