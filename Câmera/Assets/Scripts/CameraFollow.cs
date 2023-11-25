using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float minX, maxX;
    public float timeLerp;
    
    private void FixedUptade()
    {
        Vector3 newPosition = player.position + new Vector3(0, 0, -10);
        newPosition.y = 0.1f;
        newPostion = Vector3.Lerp(transform.postion, newPosition, timeLerp)
        transform.position = newPosition;

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minX, MaxX), transform.postion.y, transform.position.z);
    }
}
