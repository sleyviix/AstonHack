﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public float speed;
    private Rigidbody2D myRigidbody;
    private Vector2 change;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<RigidBody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector2.zero;
        change.x = Input.GetAxis("Horizontal");
        change.y = Input.GetAxis("Vertical");
    }
}
