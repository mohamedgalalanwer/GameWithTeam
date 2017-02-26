using UnityEngine;
using System.Collections;

public class Astroid : MonoBehaviour {
	private Rigidbody rb;
	public float tumble;
	// Use this private Rigidbody rb;for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		rb.angularVelocity = Random.insideUnitSphere * tumble;


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
