using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossHair : MonoBehaviour {
    public Texture2D crossHair;
    void OnGUI () {
        Rect rec = new Rect((Input.mousePosition.x - crossHair.width / 4), ((Screen.height - Input.mousePosition.y+22) - crossHair.height / 4), crossHair.width / 2, crossHair.height / 2);
        GUI.DrawTexture(rec, crossHair);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
