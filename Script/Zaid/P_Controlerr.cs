using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_Controlerr : MonoBehaviour {

	public Camera myCamera;
	public LayerMask detectorLayer;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		LookAtMousePostion ();
	}

	void LookAtMousePostion(){
		Ray ray = myCamera.ScreenPointToRay (Input.mousePosition);

		RaycastHit hit;


		if (Physics.Raycast(ray, out hit, Mathf.Infinity, detectorLayer)) {
		
			transform.LookAt (hit.point);
			transform.eulerAngles = new Vector3 (0, transform.eulerAngles.y, 0);
		
		
		
		}
	
	
	
	
	}



}
