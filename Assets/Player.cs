using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

	float moveBall;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		moveBall=CrossPlatformInputManager.GetAxis ("Horizontal");
		float amount = transform.position.z + moveBall;
		transform.position = new Vector3 (transform.position.x, transform.position.y, amount);
	}
}
