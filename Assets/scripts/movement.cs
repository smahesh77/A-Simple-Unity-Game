using UnityEngine;
using UnityEngine.SceneManagement;
    

public class movement : MonoBehaviour
{
    public Rigidbody rb;
    public float forward, sideways, jump;
    public Vector3 unit,rot,swap;
    public int a;
    

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey("w")|| Input.GetKey(KeyCode.UpArrow))
            rb.AddForce(0, 0, forward*Time.deltaTime, ForceMode.VelocityChange);
        if (Input.GetKey("s") || Input.GetKey(KeyCode.DownArrow))
            rb.AddForce(0, 0, -forward * Time.deltaTime, ForceMode.VelocityChange);
        if (Input.GetKey("a")||Input.GetKey(KeyCode.LeftArrow))
            rb.AddForce(-sideways * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        if (Input.GetKey("d")||Input.GetKey(KeyCode.RightArrow))
            rb.AddForce(sideways * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        
        if (Input.GetKey(KeyCode.Escape))
        {
            FindObjectOfType<control>().assign(SceneManager.GetActiveScene().buildIndex - 1);
            SceneManager.LoadScene("pause");
        }

    }
    void OnCollisionEnter(Collision c)
    {
        if(c.collider.name=="ground")
        {
            Debug.Log("worf");
            if(Input.GetKey(KeyCode.Space))
            {
                rb.AddForce(0,jump * Time.deltaTime, 0, ForceMode.VelocityChange);
                Debug.Log("space");
            }
                
        }
    }
}

