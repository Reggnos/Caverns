using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeScript : MonoBehaviour {

    public Vector2 destination;
    public float speed = 1.0f;
    public GameObject node;
    public GameObject player;
    public GameObject lastNode;

    private float nodeDistance;
    private Vector2 currentPosition;

	// Use this for initialization
	void Start () {
        currentPosition = new Vector2(transform.position.x, transform.position.y);

        lastNode = transform.gameObject;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector2.MoveTowards(transform.position, destination, speed);

        if (currentPosition != destination)
        {
            if (Vector2.Distance(currentPosition, lastNode.transform.position)> nodeDistance)
            {

            }
        }
	}
}
