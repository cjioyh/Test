using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour {
    public float speed = 1f;
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x < -9f)
        {
            transform.position = new Vector3(12f, 0f, 0f);
        }
        else
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }
}
