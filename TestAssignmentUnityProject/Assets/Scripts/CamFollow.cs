//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform target;
    [Range(1f,40f)] public float laziness = 10f;
    public bool lookAtTarget = true;
    public Vector3 generalOffset;
    Vector3 whereCameraShouldBe;


    void LateUpdate()
    {
        if (target != null) {
            whereCameraShouldBe = target.position + generalOffset;
            transform.position = Vector3.Lerp(transform.position, whereCameraShouldBe, 1 / laziness);
            if (lookAtTarget) transform.LookAt(target);
        }
    }
}
