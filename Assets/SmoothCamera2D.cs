﻿
 using UnityEngine;
 using System.Collections;

public class SmoothCamera2D : MonoBehaviour
{

    public Transform player;
    

    void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y, -2);
    }
}
    