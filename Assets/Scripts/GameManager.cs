using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] ballPrefab;

    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBalls" , .4f,.4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int RandomBalls()
    {
        int randomNumber = Random.Range(0, 4);
        return randomNumber;
    }
    void SpawnBalls()
    {
        Vector3 spawnPos = new Vector3(0.236f, 1.181f, 5.053f);

        Instantiate(ballPrefab[RandomBalls()], spawnPos, ballPrefab[RandomBalls()].transform.rotation);
    }
}
