using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

    [SerializeField]
    private float speed;
    private Director director;

    private void Start()
    {
        this.director = FindObjectOfType<Director>();
    }

    void Update () {
        this.transform.Translate(Vector3.left * speed * Time.deltaTime);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.Dump();
    }

    public void Dump()
    {
        GameObject.Destroy(this.gameObject);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        this.director.EndGame();
    }
}
