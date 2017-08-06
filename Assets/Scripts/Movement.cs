using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Movement : MonoBehaviour {

    public float speed = 15f;
    public float mapWidth = 5f;
    static bool Move;
    public static int score = 0;
    public static System.Random rnd = new System.Random(DateTime.Now.Minute * 60000 + DateTime.Now.Second * 1000 + DateTime.Now.Millisecond);

    private Rigidbody2D rb;

    public GameObject pinPrefab;

    int[] positions = { 0, -6, 6 };

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if ((Input.GetButtonDown("Jump")||Input.GetMouseButtonDown(0)) &&(!Move))
        {
            if (!Move)
                SpawnPin();
            Move = true;
            if (Move)
                StartCoroutine(onCoroutine());
           
            //
        }
    }
    void FixedUpdate ()

    {
       

        /*float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;

        Vector2 newPosition = rb.position + Vector2.right * x;

        newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);

        rb.MovePosition(newPosition); */

		
	}
    IEnumerator onCoroutine()
    {
        //transform.Translate(new Vector3(positions[rnd.Next(0, 2)], 0, 0) * Time.deltaTime * speed);
        yield return new WaitForSeconds(0.5f);
        transform.position = Vector3.Lerp(transform.position, new Vector3(positions[rnd.Next(0, 3)], -12, 0), 1);
        Move = false;
        //yield return new WaitForSeconds(0.5f);
    }

    void SpawnPin()
    {
        Instantiate(pinPrefab, transform.position, transform.rotation);
    } 
}
