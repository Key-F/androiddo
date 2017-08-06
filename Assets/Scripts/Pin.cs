using UnityEngine;
using UnityEngine.UI;

public class Pin : MonoBehaviour {

    private bool isPinned = false;

    public float speed;
    public Rigidbody2D rb;
    public static bool End;
    //public Movement mov;
    //public Rotator rot;


    // Update is called once per frame
    private void Start()
    {
       
    }
    void FixedUpdate ()
    {
        if(!isPinned)
        rb.MovePosition(rb.position + Vector2.up * speed * Time.fixedDeltaTime);
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.tag == "Rotator")
        {
            transform.SetParent(col.transform);
            isPinned = true;
            Movement.score++;
            

        }
        else if (col.tag == "Pin")
        {
            //Debug.Log("END UR SCORE: " + Movement.score);
            //mov.enabled = false;
            // rot.enabled = false;
            if (PlayerPrefs.GetInt("HighScore") < Movement.score)
            {
                PlayerPrefs.SetInt("HighScore", Movement.score);
            }
            FindObjectOfType<Manage>().END();
            End = true;


        }
    }
}
