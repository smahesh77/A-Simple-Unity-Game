using UnityEngine;

public class change : MonoBehaviour
{
    public GameObject box, ball;
    public bool selbox=false, selball = false;
    public Vector3 spawn, junk;
    public movement mball, mbox;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w")|| Input.GetKey("s")|| Input.GetKey("a")|| Input.GetKey("d"))
        {
            selbox = true;
            selball = false;
        }
            
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            selball = true;
            selbox = false;
        }

        if (selbox)
        {
                //mball.transform.position = junk;
            if (Input.GetKey("g"))
            {
                
                
            }
        }

        if(selball)
        { 
               // mbox.transform.position = junk;
            if (Input.GetKey("g"))
            {
               
            }
        }
    }
}
