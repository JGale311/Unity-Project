using UnityEngine;
using System.Collections;

public class DeviceOperator : MonoBehaviour {


	public float radius = 1.5f;

	void Update() 
	{
		if(Input.GetKeyDown(KeyCode.Mouse0))
		{
			Ray ray = new Ray (transform.position, transform.forward);
			RaycastHit hit;
			if(Physics.Raycast(ray, out hit, radius))
			{
				if(hit.collider.CompareTag("Door"))
				{
					hit.collider.transform.parent.GetComponent<DoorOpen>().ChangeDoorState();

				
				

				}
			}
		
	
}
}
}