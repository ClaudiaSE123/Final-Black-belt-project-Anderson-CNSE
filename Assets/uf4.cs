using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uf4 : MonoBehaviour
{
    public float distanceToMove;

    private Vector3 startingpos;
    public Vector3 endingpos;

    public float speed = 1f;
    public float direction = -1f;

    public GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
        startingpos = transform.position;
        endingpos = new Vector3 (
            transform.position.x   + distanceToMove, transform.position.y, transform.position.z
        );
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startingpos.x) {
            speed = -5f;
        }      
        if (transform.position.x > endingpos.x) {
            speed =  5f;
        }
        transform.position = new Vector3 (
            
            transform.position.x + speed * direction * Time.deltaTime,
            transform.position.y,
            transform.position.z
        );
    }
        void OnCollisionEnter2D(Collision2D collision) {
       if (collision.collider.tag == "Player") {
            SceneManager.LoadScene("Level4");
       }
    }

}