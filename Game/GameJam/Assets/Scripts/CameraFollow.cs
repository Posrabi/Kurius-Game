using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform player;
    private Vector3 tempPosition;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (!player)
        {
            return;
        }
        tempPosition = transform.position;
        tempPosition.x = player.position.x;
        tempPosition.y = player.position.y;

        transform.position = tempPosition;


    }
}
