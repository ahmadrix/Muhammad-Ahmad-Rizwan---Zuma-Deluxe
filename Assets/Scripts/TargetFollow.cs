using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetFollow : MonoBehaviour
{
    private objects _objects;
    private Transform[] targets;
    public float speed;

    private int current;
    // Start is called before the first frame update
    void Start()
    {
        _objects = GameObject.Find("Ball").GetComponent<objects>();
        targets = _objects.target;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != targets[current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, targets[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
        else current = (current + 1) % targets.Length;
    }
}
