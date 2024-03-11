using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    bool restart;

    Score score;

    Vector2 pos;

    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.FindGameObjectWithTag("Ball").GetComponent<Score>();
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        restart = score.restart;

        if(restart){
            transform.position = new Vector2(pos.x, pos.y);
            score.restart = false;
        }
    }
}
