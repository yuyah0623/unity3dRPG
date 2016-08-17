using UnityEngine;
using System.Collections;
public class ItemController : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other) {
		if(other.name == "Player") {
			Destroy (gameObject);
			GameObject effectObj = transform.parent.FindChild ("ItemEffect(Clone)").gameObject; 
			Destroy (effectObj);
		}
	}
}
