﻿using UnityEngine;

public class MoveCamera : MonoBehaviour {

    public Transform player;
    public Vector3 offset;

    void Update() {
        transform.position = player.position + offset;
    }

}