using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy3 : MonoBehaviour
{
public float distanceToMove;

    private Vector3 startingpos;
    public Vector3 endingpos;

    public float speed = 10f;
    public float direction = -1f;

    public GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
        startingpos = transform.position;
        endingpos = new Vector3 (
            transform.position.x, transform.position.y  + distanceToMove, transform.position.z
        );
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < startingpos.y) {
            speed = -4f;
        }      
        if (transform.position.y > endingpos.y) {
            speed =  4f;
        }
        transform.position = new Vector3 (
            
            transform.position.x,
            transform.position.y + speed * direction * Time.deltaTime,
            transform.position.z
        );
    }

    void OnCollisionEnter2D(Collision2D collision) {
       if (collision.collider.tag == "Player") {
            SceneManager.LoadScene("Level3");
       }
    }


}