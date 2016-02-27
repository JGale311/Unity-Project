using UnityEngine;
using System.Collections;

public class Flashlight : MonoBehaviour {

	Light myLight;
	bool on = false;

	void Start () {

		myLight = GetComponent<Light> ();
	}

	void Update()

	{ 
		if(on)
			myLight.enabled = true;
		else if(!on)
			myLight.enabled = false;
		
		if (Input.GetKeyDown (KeyCode.F))

			on = !on;

	}

}
