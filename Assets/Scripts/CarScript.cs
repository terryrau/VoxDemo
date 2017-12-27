using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour {

	public float carSpeed = 30;
	private float turnSpeed = 150;
	public Vector3 OriginalPos;

	// Use this for initialization
	void Start () {
		OriginalPos = transform.position;
		print (OriginalPos);
	}

	void OnCollisionEnter(Collision collision)
	{
        
		print ("Bang!");
		transform.position = Vector3.Lerp (transform.position, OriginalPos, 1f);
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.Translate(Vector3.forward * Time.deltaTime * carSpeed);


		if (Input.anyKey)
		{
			print ("TAP");

			// Turn right
			transform.Rotate (new Vector3 ( 0, Time.deltaTime * turnSpeed, 0 ));
			// transform.position += transform.right * Time.deltaTime * turnSpeed;

		}
	}
}
