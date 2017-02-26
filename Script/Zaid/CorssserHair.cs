using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorssserHair : MonoBehaviour {


	public Texture2D crossHair;

	// Use this for initialization
	void OnGUI() {
		Cursor.visible = false;

		Rect crossRect = new Rect ((Input.mousePosition.x - crossHair.width / 4), ((Screen.height - Input.mousePosition.y) - crossHair.height / 4), crossHair.width / 2, crossHair.height / 2);


		GUI.DrawTexture (crossRect, crossHair);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
