using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text playerScoreText;
    public Text enemyScoreText;

    public GameObject ballScore;

    int playerPontos;
    int enemyPontos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPontos = ballScore.GetComponent<Score>().playerPontos;
        enemyPontos = ballScore.GetComponent<Score>().enemyPontos;

        playerScoreText.text = playerPontos.ToString();
        enemyScoreText.text = enemyPontos.ToString();
    }
}
