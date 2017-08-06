using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour {

    public Button Button4End;

	public void RestartGame()
    {
        SceneManager.LoadScene("play");
        Movement.score = 0;
        Button4End.gameObject.SetActive(false);
        Pin.End = false;
    }
}
