using UnityEngine;
using System.Collections;
[System.Serializable]
public class Bounduray{
	public float xMin,xMax,zMin,zMax;


}
[RequireComponent(typeof(AudioSource))]
public class PlayerControll : MonoBehaviour {
	public float speed;
	public Bounduray bounduray;
	public float itmelt;

	public GameObject shot;
	public Transform spawnshot;
	AudioSource audio;
	private float nextfire;
public float	fireRate;

	void Start(){
	
		audio = GetComponent<AudioSource>();
	}

	void Update () {
		if ((Input.GetKeyDown (KeyCode.Space)||Input.GetButton("Fire1")) && Time.time > nextfire) {
			nextfire=Time.time+fireRate;

			Instantiate(shot,spawnshot.position,spawnshot.rotation);
			audio.Play();
		}


	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float movVertical=Input.GetAxis("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, movVertical);

		GetComponent<Rigidbody>().velocity = movement * speed;

	

		GetComponent<Rigidbody>().position = new Vector3 (

			Mathf.Clamp(GetComponent<Rigidbody>().position.x,bounduray.xMin,bounduray.xMax),

			0.0f,
			Mathf.Clamp(GetComponent<Rigidbody>().position.z,bounduray.zMin,bounduray.zMax)

			);


		GetComponent<Rigidbody>().rotation = Quaternion.Euler (0.0f, 0.0f, GetComponent<Rigidbody>().position.x * -itmelt);;
	}
}
