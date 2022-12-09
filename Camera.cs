using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform CameraPanda;
    Vector3 position;

    void Start()
    {
        transform.position = CameraPanda.position;        
    }

    void Update()
    {
        position = CameraPanda.position;
        position.z = 9f;
        position.x = 0f;
        transform.position = Vector3.Lerp(transform.position, position, 1f * Time.deltaTime);
    }
}
