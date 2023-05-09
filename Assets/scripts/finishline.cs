using UnityEngine;

public class finishline : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<boss>().win();
    }
}
