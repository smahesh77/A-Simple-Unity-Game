using UnityEngine;
using UnityEngine.SceneManagement;

public class control : MonoBehaviour
{

    public bool one = false, two = false, three = false, four = false, five = false,six=false;
    public int a;

    public void Quit()
    {
        Application.Quit();
    }
    public void menu()
    {
        SceneManager.LoadScene("gameMenu");
    }
    public void assign(int a)
    {
        one = false; two = false; three = false;  four = false; five = false; six = false;
        switch (a)
        {
            case 1:one = true;break;
            case 2:two = true;break;
            case 3:three = true;break;
            case 4:four = true;break;
            case 5:five = true;break;
            case 6:six = true;break;
            default:break;
        }
    }
    public void res()
    {

        if (one)
            SceneManager.LoadScene("level 1");
        if (two)
            SceneManager.LoadScene(3);
        if (three)
            SceneManager.LoadScene(4);
        if (four)
            SceneManager.LoadScene(5);
        if (five)
            SceneManager.LoadScene(6);
        if (six)
            SceneManager.LoadScene(7);



    }
}
