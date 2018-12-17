using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carousel : MonoBehaviour {

    [SerializeField]
    private float speed;
    private float width;
    private Vector3 initialPosition;

    private void Start()
    {
        float originalWidth = GetComponent<SpriteRenderer>().size.x;
        float scale = this.transform.localScale.x;
        this.width = originalWidth * scale;
        this.initialPosition = this.transform.position;
    }

    void Update () {
        float displacement = Mathf.Repeat(this.speed * Time.time, this.width);
        this.transform.position = this.initialPosition + Vector3.left * displacement;
	}

    public float getSpeed()
    {
        return this.speed;
    }
}
