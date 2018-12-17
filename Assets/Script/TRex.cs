using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TRex : MonoBehaviour {

    [SerializeField]
    private float force;
    private Rigidbody2D physics;
    private Vector3 InitialPosition;
    private bool grounded;
    private Score score;

    private void Awake()
    {
        this.physics = GetComponent<Rigidbody2D>();
        this.score = FindObjectOfType<Score>();
        this.InitialPosition = this.transform.position;
    }

    private void Update () {
        this.score.CalculateScore();
		if(this.grounded && (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)))
        {
            this.Impulsionate();
        }
	}

    private void Impulsionate()
    {
        this.physics.AddForce(Vector2.up * force, ForceMode2D.Impulse);
        this.grounded = false;
    }

    public void RestartTRex()
    {
        this.transform.position = this.InitialPosition;
        this.score.RestartScore();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name.Equals("Ground"))
        {
            this.grounded = true;
        }
    }

}
