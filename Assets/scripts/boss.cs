using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class boss : MonoBehaviour
{
    public bool first=true;
    public GameObject level_end;

    public void win()
    {
        level_end.SetActive(true);
        Debug.Log("Level Won");
    }


    public void Endgame()
    {
        if(first)
        {
            first = false;
            Debug.Log("GAME OVER");
            FindObjectOfType<scores>().Goo();
            Invoke("Restart", 1f);
        }
        
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
