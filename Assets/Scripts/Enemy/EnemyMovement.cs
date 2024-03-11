using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate(){
        Move();
    }

    void Move(){
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, (ball.transform.position.y - transform.position.y) * speed * Time.fixedDeltaTime);
    }
}
