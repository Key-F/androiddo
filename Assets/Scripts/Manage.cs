using UnityEngine;
using UnityEngine.UI;


public class Manage : MonoBehaviour {

    public Movement mov;
    public Rotator rot1;
    public Rotator rot2;
    public Rotator rot3;
    public Camera Cam;
    public Text scoreText;
    public static Color EndColor = new Color((float)21/255, (float)122/255, (float)107/255);
    //new Color(32, 178, 170);
    // new Color((float)145/255, (float)150/255, (float)194/255);

    // Use this for initialization
    public void END()
    {
        mov.enabled = false;
        rot1.enabled = false;
        rot2.enabled = false;
        rot3.enabled = false;
        Cam.backgroundColor = EndColor;
    }
    public void Resume()
    {
        mov.enabled = true;
        rot1.enabled = true;
        rot2.enabled = true;
        rot3.enabled = true;            
    }

    private void Update()
    {
        scoreText.text = Movement.score.ToString();
    }
}

