using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    public void GoMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void qu()
    {
        Application.Quit();
    }
}
