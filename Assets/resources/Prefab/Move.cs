using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    //public float speed;
	// Use this for initialization
	void Start () {
        //var anim = gameObject.GetComponent<Animator>();
        //anim.Play("walk_1");
    }
	
	// Update is called once per frame
	void Update () {
        //var deltaTime = Time.deltaTime;
        //var pos = transform.position;
        //transform.position += new Vector3(deltaTime*speed,0f,0f);
        //transform.Translate(Vector3.left * Time.deltaTime * speed);
		if (Input.GetKeyDown(KeyCode.Space))
        {
            //gameObject.GetComponent<Animator>().CrossFade("walk_1_stop", 0.2f);
            gameObject.GetComponent<Animator>().SetBool("needStop", true);
        }
        else if(Input.GetKeyUp(KeyCode.Space))
        {
            //gameObject.GetComponent<Animator>().CrossFade("walk_1_start", 0.2f);
            gameObject.GetComponent<Animator>().SetBool("needStop", false);
        }
	}
}
