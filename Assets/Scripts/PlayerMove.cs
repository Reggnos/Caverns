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
        //Debug.Log(gameObject.transform.localEulerAngles.z);
		if (Input.GetKey(KeyCode.A))
        {
            rd.AddForce(Vector2.left * force);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rd.AddForce(Vector2.right * force);
        }
        
        /*
        if (gameObject.transform.localEulerAngles.z > 180 & gameObject.transform.localEulerAngles.z < 330)
        {
            Debug.Log("izemdju minus 30 i 180");
            transform.Rotate(0, 0, 1);
        }
        else if (gameObject.transform.localEulerAngles.z > 30 && gameObject.transform.localEulerAngles.z < 180)
        {
            transform.Rotate(0, 0, -1);
        }
        */
    }
}
