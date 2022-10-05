using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShooter : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    public GameObject player;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
        ball = Instantiate(ballPrefabs[RandomNumber()], BallSpawnPos(),
            ballPrefabs[RandomNumber()].transform.rotation);
        ball.transform.SetParent(gameObject.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            ball.GetComponent<Rigidbody>().AddForce(-ball.transform.forward*15,ForceMode.Impulse);
            StartCoroutine(NewBall());
        }
    }
    
    IEnumerator NewBall()
    {
        yield return new WaitForSeconds(0.5f);
        {
            ball= NewFrogBall();
            ball.transform.SetParent(gameObject.transform);
        }
    }
    public GameObject NewFrogBall()
    {
        return Instantiate(ballPrefabs[RandomNumber()], BallSpawnPos(), ballPrefabs[RandomNumber()].transform.rotation);
        
    }
    

    int RandomNumber()
    {
        int RandomNumber = Random.Range(0, 4);

        return RandomNumber;
    }

    Vector3 BallSpawnPos()
    {
        Vector3 pos = new Vector3(2.6f, 2f, -2.2f);

        return pos;
    }
}
