using UnityEngine;
using System.Collections;
public class ItemController : MonoBehaviour {

	public Item.itemType itemType;
	Inventry inventry = new Inventry();
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other) {
		if(other.name == "Player") {
			inventry.AddItem (itemType);
			Destroy (gameObject);
			GameObject effectObj = transform.parent.Find("ItemEffect(Clone)").gameObject; 
			Destroy (effectObj);
		}
	}
}
