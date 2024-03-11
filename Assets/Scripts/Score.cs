using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.U2D.Aseprite;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int playerPontos;
    public int enemyPontos;

    public bool restart = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "Score"){
            transform.position = new Vector2(0,0);
            restart = true;

            if(collision.gameObject.transform.position.x < 0){
                enemyPontos += 1;
            }
            else if(collision.gameObject.transform.position.x > 0){
                playerPontos += 1;
            }
        }

    }
}
