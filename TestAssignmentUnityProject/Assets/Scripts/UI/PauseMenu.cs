using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public bool isPaused = false;
    public GameObject canvas;
    public AudioSource As;

    private void Awake()
    {
        Time.timeScale = 1f;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
            Time.timeScale = isPaused ? 0 : 1;
            canvas.SetActive(isPaused);
            As.enabled = !isPaused;
            if (isPaused == false) 
            {
                GetComponent<AudioSource>().Play();
            }
        }
    }
}
