using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Restart_Button : MonoBehaviour {

    public Button Button4End;
    public Button Menu;
    public Button Resume;
    public Button Restart_Game;
    public Camera cam;
    public Text Pause;

    private Color normalCameraColor;
    private bool Menu_Opened = false;

    // Use this for initialization
    void Start () {
        
        Button4End.gameObject.SetActive(false);
        Menu.gameObject.SetActive(false);
        Resume.gameObject.SetActive(false);
        Restart_Game.gameObject.SetActive(false);
        Pause.gameObject.SetActive(false);
        normalCameraColor = cam.backgroundColor;

    }
	
	// Update is called once per frame
	void Update () {
		if (Pin.End == true)
            Button4End.gameObject.SetActive(true);

        //if(Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                PoP();
                
            }
        }

    }
    public void PoP()
    {
        Menu_Opened = !Menu_Opened;

        Menu.gameObject.SetActive(Menu_Opened);
        Resume.gameObject.SetActive(Menu_Opened);
        Restart_Game.gameObject.SetActive(Menu_Opened);

        if (Menu_Opened)
        {
            cam.backgroundColor = Manage.EndColor;
            Pause.gameObject.SetActive(true);
            FindObjectOfType<Manage>().END();
        }

        else
        {
            cam.backgroundColor = normalCameraColor;
            Pause.gameObject.SetActive(false);
            FindObjectOfType<Manage>().Resume();
        }
    }
}
