using UnityEngine;
using System.Collections;

public class TreasureChest : MonoBehaviour {

	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if(other.name == "Player") {
			anim.SetBool ("IsOpen", true);
			GameObject effectObj = Resources.Load<GameObject> ("Effects/ItemEffect");
			GameObject effect = (GameObject)Instantiate(effectObj, gameObject.transform.position, effectObj.transform.rotation);
			effect.transform.parent = gameObject.transform; 
		}
	}
}
