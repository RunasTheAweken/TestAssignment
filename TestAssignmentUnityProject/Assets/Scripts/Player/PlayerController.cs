using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    [SerializeField] 
    private float speed = 5f;
    Rigidbody rb;
    private void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    public bool IsMoving { get; private set; }
    private void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        var direction = new Vector3(horizontal, vertical, 0);
        if (direction.sqrMagnitude > 1f) direction.Normalize();

        var lastMoving = IsMoving;
        IsMoving = direction.sqrMagnitude > 0f;

        transform.Translate(direction * (speed * Time.deltaTime));
        rb.velocity = Vector3.zero;


    }
}
