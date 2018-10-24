using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 movement = new Vector3();

		if (Input.GetKey(KeyCode.DownArrow))
		{
			movement += Vector3.back;
		}
		if (Input.GetKey(KeyCode.UpArrow))
		{
			movement += Vector3.forward;
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			movement += Vector3.left;
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			movement += Vector3.right;
		}
		if (Input.GetKey(KeyCode.W))
		{
			movement += Vector3.up;
		}
		if (Input.GetKey(KeyCode.S))
		{
			movement += Vector3.down;
		}
		transform.position += movement * Time.deltaTime;
	}
}

