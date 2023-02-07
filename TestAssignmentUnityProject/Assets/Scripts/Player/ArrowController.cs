using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    [SerializeField]
    private float speed = 10.0f;
    
    public float Damage { get; set; }
    private void Update()
    {
        transform.Translate(Vector3.right * (speed * Time.deltaTime));
        Destroy(gameObject, 20);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
