using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    public float jumpPower = 60f;
    public bool isGrounded = false;
    float posX = 0.0f;
    Rigidbody2D rb;


    public AudioSource audioName;


    // Start is called before the first frame update
    void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
        posX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() 
    {
        if (Input.GetKey(KeyCode.Space) && isGrounded ) {
            GameObject.Find("Player").GetComponent<SpriteRenderer>().material.color = new Color(111, 66, 245);
            rb.AddForce(Vector3.up * (jumpPower * rb.mass * rb.gravityScale * 10.0f));
            audioName.Play();
        }
    }




    void OnCollisionEnter2D(Collision2D collision) {
       if (collision.collider.tag == "Ground") {
          isGrounded = true;
          GameObject.Find("Player").GetComponent<SpriteRenderer>().material.color = new Color(3, 252, 3);
       }




      if (collision.collider.tag == "PowerUp") {
          rb.AddForce(Vector3.up * (jumpPower * rb.mass * rb.gravityScale * 30.0f));
          GameObject.Find("Player").GetComponent<SpriteRenderer>().material.color = new Color(111, 66, 245);
          audioName.Play();

       }
       
    }


    void OnCollisionExit2D(Collision2D collision) {
       if (collision.collider.tag == "Ground") {
          isGrounded = false;
       }
    }
    void OnCollisionStay2D(Collision2D collision) {
       if (collision.collider.tag == "Ground") {
          isGrounded = true;
       }
    }



}
