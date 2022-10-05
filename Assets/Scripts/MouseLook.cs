using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(90, 0, 0);
        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.y = 0f;
        //transform.Rotate(0,0, Input.mousePosition.magnitude);
        transform.LookAt(mouseWorldPosition+ new Vector3(0,180,0));
        
    }
}
