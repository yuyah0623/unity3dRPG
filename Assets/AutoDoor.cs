using UnityEngine;
using System.Collections;

public class AutoDoor : MonoBehaviour {

	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter (Collider other) {
		if (other.name == "ThirdPersonController") {
			anim.SetBool ("IsOpen", true);
		}
	}
}
