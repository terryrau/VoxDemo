using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour {

	public float carSpeed = 30;
	private float turnSpeed = 150;
	public Vector3 OriginalPos;

	// Use this for initialization
	void Start () {
		//OriginalPos = transform.position;
		print (OriginalPos);
	}

	void OnCollisionEnter(Collision collision)
	{
        if (collision.gameObject.tag == "Rails")
        {
            print ("Bang!");
            transform.position = OriginalPos;
            transform.localEulerAngles = new Vector3(0, -90, 0);
        }
		
		
	}

   
    // Update is called once per frame
    void Update ()
	{
		transform.Translate(Vector3.forward * Time.deltaTime * carSpeed);


		if (Input.anyKey)
		{
		

			// Turn right
			transform.Rotate (new Vector3 ( 0, -Time.deltaTime * turnSpeed, 0 ));
			// transform.position += transform.right * Time.deltaTime * turnSpeed;

		}
	}
}
