using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour {

    public GameObject player;
    public float speed = 0.5f;
    private SpriteRenderer sR;
    private Rigidbody2D playerRB;

    private void Start()
    {
        playerRB = player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update () {
        Vector2 offset = new Vector2(0, Time.time * speed);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
	}
}
