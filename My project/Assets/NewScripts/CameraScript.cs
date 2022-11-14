using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
public float FollowSpeed = 2f;   
public float yOffset = 1f;
public Transform player;
void Update()
{
    Vector3 newPos = new Vector3(player.position.x, player.position.y + yOffset, -10f);
    transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed*Time.deltaTime);
}
}
