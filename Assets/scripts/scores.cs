using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class scores : MonoBehaviour
{
    public Transform player;
    public Text score, highscore;
    public double set,best=0;
    public bool alive = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        set = player.position.z + 468.6;
        if(alive)
            score.text = set.ToString("0");
        
        
    }
    public void Goo()
    {
        if (set > best)
            best = set;
        
        alive = false;
        score.color = Color.red;
        score.text = "GAME OVER";
    }
}
