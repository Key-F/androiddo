using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingButtons : MonoBehaviour {

    public GameObject btn;
    public GameObject btn1;
    public GameObject btn2;
    public GameObject btn3;
    
	
	// Update is called once per frame
	void Update () {
		btn.transform.Rotate(0f, 0f, 100f * Time.deltaTime);
        btn1.transform.Rotate(0f, 0f, -100f * Time.deltaTime);
        btn2.transform.Rotate(0f, 0f, 100f * Time.deltaTime);
        btn3.transform.Rotate(0f, 0f, -100f * Time.deltaTime);
    }
}
