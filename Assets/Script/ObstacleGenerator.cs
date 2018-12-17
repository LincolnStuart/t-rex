using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour {

    [SerializeField]
    private float initialInterval;
    [SerializeField]
    private float finalInterval;
    private float cronometer;
    [SerializeField]
    private GameObject SimpleCactus;
    [SerializeField]
    private GameObject DoubleCactus;
    [SerializeField]
    private GameObject TripleCactus;
    private GameObject[] obstacleTypes; 

    private void Start()
    {
        this.obstacleTypes = new GameObject[] {this.SimpleCactus, this.DoubleCactus, this.TripleCactus};
    }

    void Update () {
        this.cronometer -= Time.deltaTime;
        if(this.cronometer < 0)
        {
            GameObject.Instantiate(this.obstacleTypes[Random.Range(0, 3)]);
            this.cronometer = Random.Range(this.initialInterval, this.finalInterval);
        }
	}
}
