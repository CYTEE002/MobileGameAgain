using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControl : MonoBehaviour
{
    //Room Camera
    [SerializeField] private float speed;
    [SerializeField] public float yOffset;

    //follow player
    [SerializeField] private Transform player;
    [SerializeField] private float aheadDistance;
    [SerializeField] private float cameraSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z);
        transform.position = new Vector3(player.position.x, player.position.y+yOffset, transform.position.z);

    }
}
