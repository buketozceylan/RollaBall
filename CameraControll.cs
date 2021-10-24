using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{

    public GameObject ball;
    Vector3 dist;

    void Start()
    {
        dist = transform.position - ball.transform.position;
    }

    
    void LateUpdate()
    {
        transform.position = ball.transform.position + dist;
    }
}
