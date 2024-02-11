using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    [SerializeField] float minX, maxX;
    void Start()
    {
        playerTransform = GameObject.Find("Player").transform;
    }
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(playerTransform.position.x, minX, maxX), transform.position.y, transform.position.z);
    }
}