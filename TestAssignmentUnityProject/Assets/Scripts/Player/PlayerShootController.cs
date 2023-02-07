using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerShootController : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform shootPoint;
    [SerializeField] private Transform rotationPoint;




    public PauseMenu pause;

    public AudioSource source;
    public void Update()
    {
        RotateTowardsMouse();
        if(Input.GetMouseButtonDown(0))
        {
            InvokeRepeating("Shoot", 0, 0.7f);
        }
        if (Input.GetMouseButtonUp(0))
        {
            CancelInvoke("Shoot");
        }
    }

    private void RotateTowardsMouse()
    {
        if (pause.isPaused == false)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector2 direction = new Vector2(mousePosition.x - rotationPoint.position.x, mousePosition.y - rotationPoint.position.y);
            //calculate angle
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            //rotate
            rotationPoint.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
        else
        {

        }
    }

    private void Shoot()
    {
        if (pause.isPaused == false)
        {
            Instantiate(bulletPrefab, shootPoint.position, rotationPoint.rotation);
            source.Play();
        }
    }
    public void StopCorutine() 
    {
        CancelInvoke("Shoot");
    }
}
