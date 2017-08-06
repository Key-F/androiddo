using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PopUpMenu : MonoBehaviour {

    // Use this for initialization
    public void RestartGame()
    {
        SceneManager.LoadScene("play");
        Movement.score = 0;
        //Button4End.gameObject.SetActive(false);
        Pin.End = false;
    }
    
    public void Menu()
    {
        SceneManager.LoadScene("main");
    }
    public void Resume()
    {
        FindObjectOfType<Restart_Button>().PoP();
    }
}
