using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public float RotationSpeed = 1.0f;

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
		if (Input.GetKey(KeyCode.A))	
		{
			transform.Rotate(0, RotationSpeed * Time.deltaTime, 0);
		}
		if (Input.GetKey(KeyCode.D))	
		{
			transform.Rotate(0, -RotationSpeed * Time.deltaTime, 0);
		}
		transform.position += movement * Time.deltaTime;
	}
}

