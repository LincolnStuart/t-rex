using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Director : MonoBehaviour {

    [SerializeField]
    private GameObject panelGameOver;

    public void EndGame()
    {
        Time.timeScale = 0;
        this.panelGameOver.SetActive(true);
    }

    public void RestartGame()
    {
        foreach(Obstacle obstacle in FindObjectsOfType<Obstacle>())
        {
            obstacle.Dump();
        }
        FindObjectOfType<TRex>().RestartTRex();
        Time.timeScale = 1;
        this.panelGameOver.SetActive(false);
    }
}
