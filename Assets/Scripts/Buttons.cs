using System.Collections;
using System.Collections.Generic;
//using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

    public Sprite layer_black, layer_gold;
    

    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = layer_gold;
    }

    private void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().sprite = layer_black;
    }

    private void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "button":

               // if (EditorUtility.DisplayDialog("HighScore", "Wanna reset highscore?", "Yes", "No"))
                 //   PlayerPrefs.SetInt("HighScore", 0);
                break;
                
            case "play":
                SceneManager.LoadScene("play");
                Movement.score = 0; // чтобы не абузился счет
                break;
            
        }
    }
}
