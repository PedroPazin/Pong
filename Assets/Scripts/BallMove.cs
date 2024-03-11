using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    public float speed;
    float speed_;

    float directionY;

    // Start is called before the first frame update
    void Start()
    {
        speed_ = -speed;
        directionY = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move(){
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(speed_, directionY);
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Raquete"){
            speed_ *= -1;
            speed_ += speed_/10;
            directionY = collision.gameObject.GetComponent<Rigidbody2D>().velocity.y;
        }

        if(collision.gameObject.tag == "Wall"){
            directionY *= -1;
        }
    }

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "Score"){
            directionY = 0;
            if(collision.gameObject.transform.position.x < 0){
                speed_ = speed;
            }
            else if(collision.gameObject.transform.position.x > 0){
                speed_ = -speed;
            }
        }
    }
}
