using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow2D : MonoBehaviour
{
    public float FollowSpeed = 2f;
    public GameObject Target;

    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        Vector3 newPosition = Target.transform.position;
        newPosition.z = -10;
        transform.position = Vector3.Slerp(transform.position, newPosition, FollowSpeed * Time.deltaTime);
    }
}