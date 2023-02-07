using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public PauseMenu menu;
    public Score score;
    public void Restart() 
    {
        SceneManager.LoadScene("SampleScene");
        menu.isPaused = false;  
        
    }
    public void ExitGame() 
    {
        Application.Quit();
    }
}
