using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    public float force = 100.0f;

    private Rigidbody2D rd;

	// Use this for initialization
	void Start () {
        rd = GetComponent<Rigidbody2D>();
	}
	
	void Update ()
    {
		if (Input.GetKey(KeyCode.A))
        {
            rd.AddForce(Vector2.left * force);
            //rd.velocity = Vector2.left * force;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rd.AddForce(Vector2.right * force);
            //rd.velocity = Vector2.right * force;
        }
      /*  
        if ((Input.GetKeyDown(KeyCode.D)) || (Input.GetKeyDown(KeyCode.A)))
        {
            rd.velocity = new Vector2(0, 0);
        }
      */
    }
}
